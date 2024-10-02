//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Brokers.Loggings;
using College.Web.Brokers.Storages;
using College.Web.Models.Foundations.Sudents;

namespace College.Web.Services.Foundations.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public StudentService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<Student> AddStudentAsync(Student student) =>
            await this.storageBroker.InsertStudentAsync(student);

        public IQueryable<Student> RetrieveAllStudents() =>
            this.storageBroker.SelectAllStudents();

        public async ValueTask<Student> RetrieveStudentByIdAsync(int studentId) =>
            await this.storageBroker.SelectStudentByIdAsync(studentId);

        public async ValueTask<Student> ModifyStudentAsync(Student student) =>
            await this.storageBroker.UpdateStudentAsync(student);

        public async ValueTask<Student> RemoveStudentByIdAsync(int studentId)
        {
            Student maybeStudent = await this.storageBroker.SelectStudentByIdAsync(studentId);
            return await this.storageBroker.DeleteStudentAsync(maybeStudent);
        }
    }
}
