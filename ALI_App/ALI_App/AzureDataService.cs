using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALI_App
{
    public class AzureDataService
    {
        public MobileServiceClient MobileService { get; set; }
        IMobileServiceSyncTable coffeeTable;

        public async Task Initialize()
        {
            //Create our client
            MobileService = new MobileServiceClient("http://aliphonebookapp.azurewebsites.net/");

            const string path = "syncstore.db";
            //setup our local sqlite store and intialize our table
            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable();
            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

            //Get our sync table that will call out to azure
            coffeeTable = MobileService.GetSyncTable();
        }

        public async IEnumerable GetData()
        {

        }

        public async Task AddData(bool madeAtHome)
        {

        }

        public async Task SyncData()
        {

        }
    }
}
