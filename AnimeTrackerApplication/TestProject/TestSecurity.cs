using Logic.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestSecurity
    {
        [Fact]
        public void IsSecurity_ReturningHash_Correctly()
        {
            // Arrange
            string salt = "B136B6D0BA36F51C5229D182688FCE90D3517079150222900189745D1599BF745FBE7777D5CB1F797D55A733A6C1F3183C496CC5E00489FEF7AA5EFC252AC97A";
            string password = "admin";

            // Act
            string result = Security.CreateHash(salt, password);
            // Assert
            Assert.Equal("1F341D5FE64CC5DAE66A186541ABBA244B526C5CCA774169A6F6AA3428FDD647316F089E31A4C115FA9377102BFBEBD6FE2BF750BC1694DB881BCF41E774521B", result);
        }
    }
}
