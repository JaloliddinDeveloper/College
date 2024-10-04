//--------------------------------------------------
// Copyright(c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;

namespace College.Web.Controllers
{
    public class HomeController : Controller
    {

    }
}



    //[HttpGet]
    //    public async ValueTask<ViewResult> Edit(int id)
    //    {
    //        Student student = await this.studentService.RetrieveStudentByIdAsync(id);
    //        HomeEditViewModel editViewModel = new HomeEditViewModel
    //        {
    //            Id = student.Id,
    //            Name = student.Name,
    //            Age = student.Age,
    //            Cource = student.Cource,
    //            Balance = student.Balance,
    //            CreateDate = DateTimeOffset.UtcNow,
    //            Gender = student.Gender,
    //            IsMarried = student.IsMarried,
    //            //  ExistingPhotoFilePath = student.PhotofilePath
    //        };
    //        return View(editViewModel);
    //    }

    //    [HttpPost]
    //    public async ValueTask<IActionResult> Edit(HomeEditViewModel student)
    //    {
    //        Student existingStudent = await this.studentService.RetrieveStudentByIdAsync(student.Id);
    //        existingStudent.Name = student.Name;
    //        existingStudent.Age = student.Age;
    //        existingStudent.Cource = student.Cource;
    //        existingStudent.Balance = student.Balance;
    //        existingStudent.CreateDate = DateTimeOffset.Now;
    //        existingStudent.Gender = student.Gender;
    //        existingStudent.IsMarried = student.IsMarried;
    //        if (student.Photo != null)
    //        {
    //            if (student.ExistingPhotoFilePath != null)
    //            {
    //                string filePath = Path.Combine(webHost.WebRootPath, "images", student.ExistingPhotoFilePath);
    //                System.IO.File.Delete(filePath);
    //            }
    //            // existingStudent.PhotofilePath = ProcessUploadedFile(student);
    //        }
    //        this.studentService.ModifyStudentAsync(existingStudent);
    //        return RedirectToAction("Index");
    //    }
    //    [HttpPost]
    //    public async ValueTask<IActionResult> Delete(int id)
    //    {
    //        Student student = await this.studentService.RemoveStudentByIdAsync(id);
    //        return RedirectToAction("Index");
    //    }
    //    private string ProcessUploadedFile(HomeCreateViewModel student)
    //    {
    //        string uniqueFileName = string.Empty;
    //        if (student.Photo != null)
    //        {
    //            string uploadFolder = Path.Combine(webHost.WebRootPath, "images");
    //            uniqueFileName = Guid.NewGuid().ToString() + "_" + student.Photo.FileName;
    //            string imageFilePath = Path.Combine(uploadFolder, uniqueFileName);
    //            using (var fileStream = new FileStream(imageFilePath, FileMode.Create))
    //            {
    //                student.Photo.CopyTo(fileStream);
    //            }
    //        }
    //        return uniqueFileName;
    //    }
    //}

