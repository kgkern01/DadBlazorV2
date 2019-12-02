using System.Collections.Generic;

namespace DadBlazorV2.Models
{
    public class MemeResult
    {
        public bool Success { get; set; }
        public int ElapsedMS { get; set; }
        public string Warning { get; set; }
        public List<Meme> Result { get; set; }
    }

    public class Meme
    {
        public int TemplateID { get; set; }
        public int GeneratorID { get; set; }
        public int ImageID { get; set; }
        public int InstancesCount { get; set; }
        public string ImageUrl { get; set; }
    }
}
