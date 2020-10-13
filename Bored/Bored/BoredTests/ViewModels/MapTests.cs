using Bored.Mocks.Times;
using Bored.Services.Times;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bored.ViewModels.Tests
{
    [TestClass()]
    public class MapTests
    {

        [TestMethod()]
        public void ToArticle()
        {
            //Arrange
            var sut = new TimesArticleDTO()
            {
                Abstract = "This is an abstract",
                Title = "This is a title",
                Url = "This is url"
            };

            //Act
            var result = sut.ToArticle();

            //Assert
            Assert.AreEqual(result.Url, "This is url");
            Assert.AreEqual(result.Description, "This is an abstract");
            Assert.AreEqual(result.Heading, "This is a title");
        }

        [TestMethod()]
        public void ToArticles()
        {
            //Arrange
            var sut = new TimesArticleResultDTO()
            {
                Results = new TimesArticleDTO[]
                {
                    new TimesArticleDTO() { Abstract = "1" },
                    new TimesArticleDTO() { Abstract = "2" },
                    new TimesArticleDTO() { Abstract = "3" }
                }

            };

            //Act
            var result = sut.ToArticles();

            //Assert
            Assert.AreEqual(result.Count(), 3);
            Assert.AreEqual(result.First().Description, "1");
        }

        [TestMethod()]
        public async Task Test()
        {
            //Arrange
            var sut = new TimesApiServiceMock();

            //Act
            var result = await sut.GetArticles();

            //Assert
            
        }

    }

}