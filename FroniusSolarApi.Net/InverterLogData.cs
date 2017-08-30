using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FroniusSolarApi
{
    public class InverterLogData
    {
        public InverterLogData(InverterLogDataJson jsonData)
        {
            this.TimeStamp = DateTime.Now;
            this.DayEnergy = jsonData.Body.Data.DAY_ENERGY.Value;
            this.CurrentPower = jsonData.Body.Data.PAC != null ? jsonData.Body.Data.PAC.Value : 0;
            this.TotalEnergy = jsonData.Body.Data.TOTAL_ENERGY.Value;
        }

        public DateTime TimeStamp { get; set; }

        public double CurrentPower { get; set; }
        public double DayEnergy { get; set; }
        public double TotalEnergy { get; set; }
    }

    public class InverterLogDataJson
    {
        public InverterLogDataBody Body { get; set; }
    }

    public class InverterLogDataBody
    {
        public InverterLogDataData Data { get; set; }
    }

    public class InverterLogDataData
    {
        public InverterLogDataValue DAY_ENERGY { get; set; }
        public InverterLogDataValue TOTAL_ENERGY { get; set; }

        public InverterLogDataValue PAC { get; set; }
    }

    public class InverterLogDataValue
    {
        public double Value { get; set; }
        public string Unit { get; set; }
    }
}