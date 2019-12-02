namespace DadBlazorV2.Models
{
    public class JokeResult
    {
        public string id { get; set; }
        public string joke { get; set; }
        public int status { get; set; }
    }

    public class JokeValue
    {
        public int id { get; set; }

        private string _joke;
        public string joke
        {
            get => _joke;
            set => _joke = value?.Replace("&quot;", "\"");
        }
    }
}
