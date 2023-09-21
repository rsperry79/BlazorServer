namespace Table.Useful.Models

{
    using Newtonsoft.Json;
    using System;

    public class JudgementData
    {
        private int rating;
        private string comments;

        [JsonProperty("Comments")]
        public string Comments
        {
            get => comments; set
            {
                comments = value;
                NotifyStateChanged();
            }
        }

        [JsonProperty("Comments")]
        public int Rating
        {
            get => rating; set
            {
                rating = value;
                NotifyStateChanged();
            }
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
