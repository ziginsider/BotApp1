﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;

namespace BotApp1.OpenWeatherMap
{
    [Serializable]
    public enum Measurement { Temp = 1, Humidity = 2, Pressure = 4, None = 0 };

    [Serializable]
    public class WeatherParam
    {

        public string Location { get; set; }

        public DateTime When { get; set; }
        public Measurement MeasurementType { get; set; }
        public WeatherParam()
        {
            When = DateTime.Now;
            MeasurementType = Measurement.Temp;
        }
        public void Today()
        {
            When = DateTime.Now;
        }
        public void Tomorrow()
        {
            When = DateTime.Now.AddDays(1);
        }

        public void AlsoMeasure(Measurement M)
        {
            MeasurementType |= M;
        }

        public bool Measure(Measurement M)
        {
            return (M & MeasurementType) > 0;
        }

        public int Offset
        {
            get
            {
                return (int)(((float)(When - DateTime.Now).Hours) / 24.0 + 0.5);
            }
        }

        public async Task<string> BuildResult()
        {
            WeatherClient OWM = new WeatherClient("42ec5c3a4c118c7f417109879bf7d9d9");
            var res = await OWM.Forecast(Location);
            var r = res[Offset];
            StringBuilder sb = new StringBuilder();
            if (Measure(Measurement.Temp))
            {
                sb.Append($"The temperature on {r.Date} in {Location} is {r.Temp}\r\n");
            }
            if (Measure(Measurement.Pressure))
            {
                sb.Append($"The pressure on {r.Date} in {Location} is {r.Pressure}\r\n");
            }
            if (Measure(Measurement.Humidity))
            {
                sb.Append($"Humidity on {r.Date} in {Location} is {r.Humidity}\r\n");
            }
            if (sb.Length == 0) return "I do not understand";
            else return sb.ToString();
        }

    }
}