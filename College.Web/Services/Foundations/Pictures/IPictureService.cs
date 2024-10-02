﻿//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Models.Foundations.Pictures;
using College.Web.Models.Foundations.Sudents;

namespace College.Web.Services.Foundations.Pictures
{
    public interface IPictureService
    {
        ValueTask<Picture> AddPictureAsync(Picture picture);
        IQueryable<Picture> RetrieveAllPictures();
        ValueTask<Picture> RetrievePictureByIdAsync(int pictureId);
        ValueTask<Picture> ModifyPictureAsync(Picture picture);
        ValueTask<Picture> RemovePictureByIdAsync(int pictureId);
    }
}
