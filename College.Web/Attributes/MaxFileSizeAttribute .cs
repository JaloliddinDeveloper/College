//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace College.Web.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int maxFileSizeKB;
        private readonly int maxFileSize;

        public MaxFileSizeAttribute(int maxFileSizeInKB)
        {
            this.maxFileSize = maxFileSizeInKB;
            maxFileSizeKB = maxFileSize * 1024;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                if (file.Length > maxFileSizeKB)
                {
                    return new ValidationResult($"The file size exceeds the limit allowed {this.maxFileSize} KB.");
                }
            }

            return ValidationResult.Success;
        }
    }
}

