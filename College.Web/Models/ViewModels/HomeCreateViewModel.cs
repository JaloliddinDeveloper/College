//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
namespace College.Web.Models.ViewModels
{
    public class HomeCreateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Kurs { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset CreateDate { get; set; }
    }
}
