//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using College.Web.Models.Foundations.Sudents;
using Microsoft.EntityFrameworkCore;

namespace College.Web.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Student> Students { get; set; }
    }
}
