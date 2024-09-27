//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Models.Foundations.Sudents;
using College.Web.Models.ViewModels;
using College.Web.Services.Foundations.Students;
using Microsoft.AspNetCore.Mvc;

namespace College.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService studentService;
        private readonly IWebHostEnvironment webHost;

        public HomeController(
            IStudentService studentService,
            IWebHostEnvironment webHost)
        {
            this.studentService = studentService;
            this.webHost = webHost;
        }

        public ViewResult Index(Student student)
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel
            {
                Students = this.studentService.RetrieveAllStudents()
            };
            return View(viewModel);
        }

        public async ValueTask<ViewResult> Details(int id)
        {
            Student student = await this.studentService.RetrieveStudentByIdAsync(id);

            HomeDetailsViewModel viewModel = new HomeDetailsViewModel()
            {
                Student = student,
                Title = "Student Details"
            };

            return View(viewModel);
        }

        [HttpGet]
        public ViewResult Create() =>
             View();

        [HttpPost]
        public async ValueTask<IActionResult> Create(HomeCreateViewModel student)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(student);

                Student newStudent = new Student
                {
                    Name = student.Name,
                    Age = student.Age,
                    Cource = student.Cource,
                    Balance = student.Balance,
                    CreateDate =DateTimeOffset.UtcNow,
                    Gender = student.Gender,
                    IsMarried = student.IsMarried,
                    PhotofilePath = uniqueFileName
                };

                newStudent = await this.studentService.AddStudentAsync(newStudent);
                return RedirectToAction("details", new { id = newStudent.Id });
            }

            return View();
        }

        [HttpGet]
        public async ValueTask<ViewResult> Edit(int id)
        {
            Student student = await this.studentService.RetrieveStudentByIdAsync(id);
            HomeEditViewModel editViewModel = new HomeEditViewModel
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                Cource = student.Cource,
                Balance = student.Balance,
                CreateDate = DateTimeOffset.UtcNow,
                Gender = student.Gender,
                IsMarried = student.IsMarried,
                ExistingPhotoFilePath = student.PhotofilePath
            };
            return View(editViewModel);
        }

        [HttpPost]
        public async ValueTask<IActionResult> Edit(HomeEditViewModel student)
        {
            Student existingStudent = await this.studentService.RetrieveStudentByIdAsync(student.Id);
            existingStudent.Name = student.Name;
            existingStudent.Age = student.Age;
            existingStudent.Cource = student.Cource;
            existingStudent.Balance = student.Balance;
            existingStudent.CreateDate = DateTimeOffset.Now;
            existingStudent.Gender = student.Gender;
            existingStudent.IsMarried = student.IsMarried;
            if (student.Photo != null)
            {
                if (student.ExistingPhotoFilePath != null)
                {
                    string filePath = Path.Combine(webHost.WebRootPath, "images", student.ExistingPhotoFilePath);
                    System.IO.File.Delete(filePath);
                }
                existingStudent.PhotofilePath = ProcessUploadedFile(student);
            }
            this.studentService.ModifyStudentAsync(existingStudent);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async ValueTask<IActionResult> Delete(int id)
        {
            Student student = await this.studentService.RemoveStudentByIdAsync(id);
            return RedirectToAction("Index");
        }
        private string ProcessUploadedFile(HomeCreateViewModel student)
        {
            string uniqueFileName = string.Empty;
            if (student.Photo != null)
            {
                string uploadFolder = Path.Combine(webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + student.Photo.FileName;
                string imageFilePath = Path.Combine(uploadFolder, uniqueFileName);
                using (var fileStream = new FileStream(imageFilePath, FileMode.Create))
                {
                    student.Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
