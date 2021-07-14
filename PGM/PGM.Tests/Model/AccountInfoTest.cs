using System;
using Xunit;

namespace PGM.Tests.Model
{
    public class AccountInfoTest
    {

        internal struct FormEntry
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Expires { get; set; }
            public short? ExpiresDays { get; set; }
            public string Password { get; set; }
        }

        [Fact]
        public void GivenInfoData_WhenYouHaveTheFieldsFromForm_ThenTryToDumpTheAccountInfo()
        {
            var formEntry = new FormEntry()
            {
                Name =  "mytest@hotmail.com",
                Description = "Account Test from Hotmail",
                Expires = false
            };

            //Insert the suggested password

            //Mock the data.
        }

    }
}
