﻿//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Models.Foundations.Sudents;
using System.Linq;
using System.Threading.Tasks;

namespace College.Web.Services.Foundations.Students
{
    public interface IStudentService
    {
        ValueTask<Student> AddStudentAsync(Student student);
        ValueTask<IQueryable<Student>> RetrieveAllStudentsAsync();
        ValueTask<Student> RetrieveStudentByIdAsync(int studentId);
        ValueTask<Student> ModifyStudentAsync(Student student);
        ValueTask<Student> RemoveStudentByIdAsync(int studentId);
    }
}
