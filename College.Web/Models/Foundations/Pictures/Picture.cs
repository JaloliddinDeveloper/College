//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Models.Foundations.Sudents;

namespace College.Web.Models.Foundations.Pictures
{
    public class Picture
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
      
    }
}
