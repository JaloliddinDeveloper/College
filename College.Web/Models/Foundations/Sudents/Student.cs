//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
namespace College.Web.Models.Foundations.Sudents
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Kurs { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset CreateDate { get; set; }
    }
}
