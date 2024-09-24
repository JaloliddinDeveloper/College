//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Models.Foundations.Sudents;

namespace College.Web.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IQueryable<Student> Students { get; set; }
    }
}
