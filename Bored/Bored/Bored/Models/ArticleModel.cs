using System;
using System.Collections.Generic;
using System.Text;

namespace Bored.Models
{
    public class ArticleModel: BaseModel
    {
        public string Heading { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
