//-----------------------------------------------------------------------
// <copyright file="CalculateChargesServiceTests.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CustomerInvitation.Services.Services.Tests
{
    using CustomerInvitation.Domain.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// test class for Calculate Charges Service
    /// </summary>
    [TestClass]
    public class CalculateChargesServiceTests
    {
        /// <summary>
        /// Positive test method for Calculate Charges Service 
        /// </summary>
        [TestMethod]
        public void CalculateChargesTestPositive()
        {
            Customer expectedCustomer = new Customer()
            {
                ID = 1,
                Title = "Miss",
                FirstName = "Sally",
                Surname = "Smith",
                ProductName = "Standard Cover",
                PaymentAmount = 2000,
                AnnualPremium = 1250,
                CreditCharge = 62.5M,
                AverageMonthly = 109.37M,
                TotalPremium = 1312.5M
            };
            Customer customer = new Customer() { ID = 1, Title = "Miss", FirstName = "Sally", Surname = "Smith", ProductName = "Standard Cover", PaymentAmount = 2000, AnnualPremium = 1250 };
            CalculateChargesService calService = new CalculateChargesService();
            var actualCustomer = calService.CalculateCharges(customer);

            Assert.AreEqual(expectedCustomer.CreditCharge, actualCustomer.CreditCharge);
        }

        /// <summary>
        /// Negative test method for Calculate Charges Service 
        /// </summary>
        [TestMethod]
        public void CalculateChargesTestNegative()
        {
            Customer expectedCustomer = new Customer()
            {
                ID = 1,
                Title = "Miss",
                FirstName = "Sally",
                Surname = "Smith",
                ProductName = "Standard Cover",
                PaymentAmount = 2000,
                AnnualPremium = 1250,
                CreditCharge = 64.5M,
                AverageMonthly = 109.37M,
                TotalPremium = 1312.5M
            };
            Customer customer = new Customer() { ID = 1, Title = "Miss", FirstName = "Sally", Surname = "Smith", ProductName = "Standard Cover", PaymentAmount = 2000, AnnualPremium = 1250 };
            CalculateChargesService calService = new CalculateChargesService();
            var actualCustomer = calService.CalculateCharges(customer);

            Assert.AreNotEqual(expectedCustomer.CreditCharge, actualCustomer.CreditCharge);                   
        }
    }
}