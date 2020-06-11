using Newtonsoft.Json;
using System.Collections.Generic;

namespace Weather.Models
{

    public class Temp
    {

        [JsonProperty("day")]
        public double day { get; set; }

        [JsonProperty("min")]
        public double min { get; set; }

        [JsonProperty("max")]
        public double max { get; set; }

        [JsonProperty("night")]
        public double night { get; set; }

        [JsonProperty("eve")]
        public double eve { get; set; }

        [JsonProperty("morn")]
        public double morn { get; set; }
    }

    public class FeelsLike
    {

        [JsonProperty("day")]
        public double day { get; set; }

        [JsonProperty("night")]
        public double night { get; set; }

        [JsonProperty("eve")]
        public double eve { get; set; }

        [JsonProperty("morn")]
        public double morn { get; set; }
    }

    public class Weather
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("main")]
        public string main { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }
    }

    public class Daily
    {

        [JsonProperty("dt")]
        public int dt { get; set; }

        [JsonProperty("sunrise")]
        public int sunrise { get; set; }

        [JsonProperty("sunset")]
        public int sunset { get; set; }

        [JsonProperty("temp")]
        public Temp temp { get; set; }

        [JsonProperty("feels_like")]
        public FeelsLike feels_like { get; set; }

        [JsonProperty("pressure")]
        public int pressure { get; set; }

        [JsonProperty("humidity")]
        public int humidity { get; set; }

        [JsonProperty("dew_point")]
        public double dew_point { get; set; }

        [JsonProperty("wind_speed")]
        public double wind_speed { get; set; }

        [JsonProperty("wind_deg")]
        public int wind_deg { get; set; }

        [JsonProperty("weather")]
        public IList<Weather> weather { get; set; }

        [JsonProperty("clouds")]
        public int clouds { get; set; }

        [JsonProperty("rain")]
        public double rain { get; set; }

        [JsonProperty("uvi")]
        public double uvi { get; set; }
    }

    public class OneCallApi
    {

        [JsonProperty("lat")]
        public double lat { get; set; }

        [JsonProperty("lon")]
        public double lon { get; set; }

        [JsonProperty("timezone")]
        public string timezone { get; set; }

        [JsonProperty("timezone_offset")]
        public int timezone_offset { get; set; }

        [JsonProperty("daily")]
        public IList<Daily> daily { get; set; }
    }

}