//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Attributes;
using College.Web.Models.Foundations.Sudents;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace College.Web.Models.ViewModels
{
    public class StudentCreateViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhotoCount { get; set; } 
        public List<IFormFile> Photos { get; set; }
    }
}

