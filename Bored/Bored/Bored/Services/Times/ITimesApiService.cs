using System.Threading.Tasks;

namespace Bored.Services.Times
{
    public interface ITimesApiService
    {
        Task<TimesArticleResultDTO> GetArticles();

        //API:s usually have multiple methods
        Task<string> SomeOtherMethod1();
        Task<string> SomeOtherMethod2();
    }
}

