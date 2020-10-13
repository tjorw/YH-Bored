using Bored.Models;
using Bored.Services.Bored;
using Bored.Services.Times;
using System.Collections.Generic;
using System.Linq;

namespace Bored
{
    public static class Maps
    {

        public static IEnumerable<ArticleModel> ToArticles(this TimesArticleResultDTO dto)
        {
            return dto.Results.Select(a => a.ToArticle());
        }

        public static ArticleModel ToArticle(this TimesArticleDTO dto)
        {
            return new ArticleModel()
            {
                Description = dto.Abstract,
                Heading = dto.Title,
                Url = dto.Url
            };
        }


        public static ActivityModel ToActivity(this BoredActivityDTO dto )
        {
            return new ActivityModel()
            {
                Accessibility = dto.accessibility,
                Activity = dto.activity,
                Key = dto.key,
                Link = dto.link,
                Participants = dto.participants,
                Price = dto.price,
                Type = dto.type
            };
        }
    }
}

