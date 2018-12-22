using System;
using System.Collections.Generic;
using System.Text;

namespace ALI_App
{
    public class ali_phonebook_data
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }

        public string name { get; set; }
        public string city { get; set; }
        public string place { get; set; }
        public string job { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string sons { get; set; }

    }
}
