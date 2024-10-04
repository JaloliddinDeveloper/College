//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Brokers.Loggings;
using College.Web.Brokers.Storages;
using College.Web.Models.Foundations.Pictures;

namespace College.Web.Services.Foundations.Pictures
{
    public class PictureService : IPictureService
    {
        private IStorageBroker storageBroker;
        private ILoggingBroker loggingBroker;

        public PictureService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<Picture> AddPictureAsync(Picture picture) =>
            await this.storageBroker.InsertPictureAsync(picture);

        public async ValueTask<IQueryable<Picture>> RetrieveAllPicturesAsync() =>
            await this.storageBroker.SelectAllPicturesAsync();

        public async ValueTask<Picture> RetrievePictureByIdAsync(int pictureId) =>
            await this.storageBroker.SelectPictureByIdAsync(pictureId);

        public async ValueTask<Picture> ModifyPictureAsync(Picture picture) =>
            await this.storageBroker.UpdatePictureAsync(picture);


        public async ValueTask<Picture> RemovePictureByIdAsync(int pictureId)
        {
            Picture maybePicture = await this.storageBroker.SelectPictureByIdAsync(pictureId);
            return await this.storageBroker.DeletePictureAsync(maybePicture);
        }
    }
}
