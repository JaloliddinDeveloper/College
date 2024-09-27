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
        public uint Age { get; set; }
        public Cource Cource { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public GenderType Gender {  get; set; }
        public bool IsMarried { get; set; }
        public string PhotofilePath { get; set; }
    }
}
