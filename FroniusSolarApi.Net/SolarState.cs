using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace FroniusSolarApi
{
    public class SolarState
    {
        private string url;

        public SolarState(string inverterIpAdress, int deviceNumber = 1)
        {
            this.url = string.Concat("http://", inverterIpAdress, "/solar_api/v1/GetInverterRealtimeData.cgi?Scope=Device&DeviceId=", deviceNumber,
                "&DataCollection=CommonInverterData");
        }

        public InverterLogData GetValues()
        {
            WebClient client = new WebClient();

            // Download string:

            try
            {
                string json = client.DownloadString(url);
                var obj = JsonConvert.DeserializeObject<InverterLogDataJson>(json);

                return new InverterLogData(obj);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}