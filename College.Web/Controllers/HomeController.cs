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

        public HomeController(IStudentService studentService) =>
            this.studentService = studentService;

        public ViewResult Index(Student student)
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel
            {
                Students = this.studentService.RetrieveAllStudents()
            };
            return View(viewModel);
        }

        public async ValueTask<ViewResult> Details(int? id)
        {
            var student =
                await this.studentService
                .RetrieveStudentByIdAsync(id ?? 1);

            return View(student);
        }

        [HttpGet]
        public ViewResult Create() =>
             View();

        [HttpPost]
        public async ValueTask<IActionResult> Create(Student student)
        {
            var students = await this.studentService
                .AddStudentAsync(student);

            return RedirectToAction("details", new { id = student.Id });
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
                CreateDate = student.CreateDate,
                Gender = student.Gender,
                IsMarried= student.IsMarried,
            };
            return View(editViewModel);
        }

      

        [HttpPost]
        public async ValueTask<IActionResult> Edit(HomeEditViewModel student)
        {
            if (ModelState.IsValid)
            {
                Student existingStudent = await this.studentService.RetrieveStudentByIdAsync(student.Id);
                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;
                existingStudent.Cource = student.Cource;
                existingStudent.Balance = student.Balance;
                existingStudent.CreateDate = student.CreateDate;
                existingStudent.Gender= student.Gender;
                existingStudent.IsMarried = student.IsMarried;
                this.studentService.ModifyStudentAsync(existingStudent);
                return RedirectToAction("index");
            }
            return View();
        }

        [HttpPost]
        public async ValueTask<IActionResult> Delete(int id)
        {
           Student student= await this.studentService.RemoveStudentByIdAsync(id);
            return RedirectToAction("index");
        }
    }
}
