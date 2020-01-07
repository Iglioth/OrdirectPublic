using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ordirect.Core;
using OrdirectWebsite;

namespace OrdirectTest
{
    [TestClass]
    public class AccountTest
    {
        IAccountContext context;

        [TestInitialize]
        public void SetUp()
        {
            context = new AccountTestContext();
            context.CreateAccount("Japser", "Kronig", "JasperKronig@DE.nl", "hitcher312", 0, "Klant");
        }

        [TestMethod]
        public void CreateAccountTest()
        {
            bool created = context.CreateAccount("Jasper", "Kronig", "JasperKronig@DE.nl", "hitcher312", 0, "Klant");

            Assert.IsTrue(created);
        }

        [TestMethod]
        public void CreatBadAccountTest()
        {
            bool created = context.CreateAccount(null, null, null, null, 0, null);
            Assert.IsFalse(created);
        }

        [TestMethod]
        public void GetAccountByIdTest()
        {
            Account account = context.GetAccountByID(1);

            Assert.IsNotNull(account);
            Assert.AreEqual(account.Voornaam, "Japser");
        }

        [TestMethod]
        public void CheckTest()
        {
            Account account = context.Check("JasperKronig@DE.nl");

            Assert.IsNotNull(account);
            Assert.AreEqual(account.Email, "JasperKronig@DE.nl");
        }

        [TestMethod]
        public void CheckFailTest()
        {
            Account account = context.Check("JasperKroniaaegg@DE.nl");

            Assert.IsNull(account);
        }

        [TestMethod]
        public void GetNoAccountByIdTest()
        {
            Account account = context.GetAccountByID(420);

            Assert.IsNull(account);
        }
        /*
        public void EmptyAccount()
        {
            Account account = new Account();

            Assert.IsNull(account);
        }*/
    }
}
