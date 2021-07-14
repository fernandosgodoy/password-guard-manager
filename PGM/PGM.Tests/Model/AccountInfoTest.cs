using PGM.Tests.Entries;
using System;
using Xunit;

namespace PGM.Tests.Model
{
    public class AccountInfoTest
    {

        [Fact]
        public void GivenInfoData_WhenYouHaveTheFieldsFromForm_ThenTryToDumpTheAccountInfo()
        {
            var formEntry = new FormEntry()
            {
                Name =  "mytest@hotmail.com",
                Description = "Account Test from Hotmail",
                Expires = false
                //Retrieve the random password
            };

            //Insert the suggested password


            //Mock the data.
        }

    }
}
