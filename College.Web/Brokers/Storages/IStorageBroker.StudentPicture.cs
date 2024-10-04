//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Models.Foundations.Pictures;

namespace College.Web.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Picture> InsertPictureAsync(Picture picture);
        ValueTask<IQueryable<Picture>> SelectAllPicturesAsync();
        ValueTask<Picture> SelectPictureByIdAsync(int pictureId);
        ValueTask<Picture> UpdatePictureAsync(Picture picture);
        ValueTask<Picture> DeletePictureAsync(Picture picture);
    }
}
