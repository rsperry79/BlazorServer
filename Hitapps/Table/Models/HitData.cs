namespace Table.Useful.Models

{
    using Newtonsoft.Json;
    using System;

    public class HitData
    {
        private string answer;
        private string market;
        private string query;
        private Uri url;
        private string sourceTitle;
        private string tableCount;
        private string scenario;
        private string subScenario;
        private string qLocation;
        private string rand;
        private string queryType;

        [JsonProperty("Market")]
        public string Market
        {
            get => market; set
            {
                market = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("Query")]
        public string Query
        {
            get => query; set
            {
                query = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("Answer")]
        public string Answer
        {
            get => answer; set
            {
                answer = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("Url")]
        public Uri Url
        {
            get => url; set
            {
                url = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("SourceTitle")]
        public string SourceTitle
        {
            get => sourceTitle; set
            {
                sourceTitle = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("TableCount")]
        public string TableCount
        {
            get => tableCount; set
            {
                tableCount = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("Scenario")]
        public string Scenario
        {
            get => scenario; set
            {
                scenario = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("SubScenario")]
        public string SubScenario
        {
            get => subScenario; set
            {
                subScenario = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("QLocation")]
        public string QLocation
        {
            get => qLocation; set
            {
                qLocation = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("rand")]
        public string Rand
        {
            get => rand; set
            {
                rand = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("QueryType")]
        public string QueryType
        {
            get => queryType; set
            {
                queryType = value;
                NotifyStateChanged();
            }
        }


        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
