//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Models.Foundations.Sudents;
using System.ComponentModel.DataAnnotations;

namespace College.Web.Models.ViewModels
{
    public class HomeCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Kurs is required")]
        public Cource Cource { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Balance must be positive")]
        public decimal Balance { get; set; }

        [Required(ErrorMessage = "Create Date is required")]
        public DateTimeOffset CreateDate { get; set; }

        [Required(ErrorMessage = "Please select a gender")]
        public GenderType Gender { get; set; }

        public bool IsMarried { get; set; } 
    }
}

