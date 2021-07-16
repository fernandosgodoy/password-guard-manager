using Moq.AutoMock;
using PGM.InfraHelpers.ModelHelpers;
using PGM.Model;
using PGM.Tests.Entries;
using Xunit;

namespace PGM.Tests.Model
{
    public class AccountInfoTest
    {
        private readonly AutoMocker _autoMocker;

        public AccountInfoTest()
        {
            this._autoMocker = new AutoMocker();
        }

        [Fact]
        public void GivenTheProjectEntities_WhenAfterYouWroteTheClass_ThenCheckTheRulesForTheModel()
        {
            Assert.True(typeof(AccountInfo).CheckHasDefinedPrimaryKey(), "Entity doesn't implement the correct model rules.");
        }

    }
}
