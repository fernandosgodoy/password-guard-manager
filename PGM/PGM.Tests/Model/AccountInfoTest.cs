using Moq.AutoMock;
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
        public void GivenInfoData_WhenYouHaveTheFieldsFromForm_ThenTryToDumpTheAccountInfo()
        {
            var formEntry = new AccountInfoFormEntry()
            {
                Name =  "mytest@hotmail.com",
                Description = "Account Test from Hotmail",
                Expires = false
                //Retrieve the random password
            };

            //Insert the suggested password

            //Mock the data.
            this._autoMocker.CreateInstance<AccountInfo>();
            
        }

    }
}
