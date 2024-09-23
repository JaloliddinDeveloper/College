﻿//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.EntityFrameworkCore;

namespace College.Web.Brokers.Storages
{
    public partial class StorageBroker : DbContext, IStorageBroker
    {
        private readonly IConfiguration configuration;
        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }
        private async ValueTask<T> InsertAsync<T>(T @object) where T : class
        {
            using var broker = new StorageBroker(this.configuration);
            broker.Entry<T>(@object).State = EntityState.Added;
            await broker.SaveChangesAsync();
            return @object;
        }
        private IQueryable<T> SelectAll<T>() where T : class
        {
            using var broker = new StorageBroker(this.configuration);
            return broker.Set<T>();
        }
        private async ValueTask<T> SelectAsync<T>(params object[] objectIds) where T : class
        {
            using var broker = new StorageBroker(this.configuration);
            return await broker.FindAsync<T>(objectIds);
        }
        private async ValueTask<T> UpdateAsync<T>(T @object) where T : class
        {
            using var broker = new StorageBroker(this.configuration);
            broker.Entry<T>(@object).State = EntityState.Modified;
            await broker.SaveChangesAsync();
            return @object;
        }
        private async ValueTask<T> DeleteAsync<T>(T @object) where T : class
        {
            using var broker = new StorageBroker(this.configuration);
            broker.Entry<T>(@object).State = EntityState.Deleted;
            await broker.SaveChangesAsync();
            return @object;
        }
        public override void Dispose() { }
    }
}
