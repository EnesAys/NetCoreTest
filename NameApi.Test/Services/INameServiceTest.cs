using NetCoreTest.Services;
using Xunit;

namespace NameApi.Test.Services
{
    public class INameServiceTest
    {
        private INameService _nameService;
        public INameServiceTest()
        {
            _nameService = new NameService();
        }

        [Fact]
        public void Should_isValidName_Return_False_When_ParamisEmpty()
        {
            string name = string.Empty;
            var result = _nameService.isValidName(name);
            Assert.False(result);
        }

        [Fact]
        public void Should_isValidName_Return_True_When_ParamisnotEmpty()
        {
            string name = "Enes Aysan";
            var result = _nameService.isValidName(name);
            Assert.True(result);
        }
    }
}
