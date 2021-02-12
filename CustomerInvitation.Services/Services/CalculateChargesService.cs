//-----------------------------------------------------------------------
// <copyright file="CalculateChargesService.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CustomerInvitation.Services.Services
{
    using System;   
    using System.Configuration;
    using CustomerInvitation.Domain.Models;
    using CustomerInvitation.Services.Interfaces;

    /// <summary>
    /// Calculate service class implements ICalculate service interface
    /// </summary>
    public class CalculateChargesService : ICalculateChargesService
    {
         /// <summary>
        /// constant for CreditPercentage
        /// </summary>
        private const int CreditPerc = 5;

        /// <summary>
        /// Calculate Charges method calculates different amounts for customers
        /// </summary>
        /// <param name="customer">parameter customer</param>
        /// <returns>returns Customer</returns>
        public Customer CalculateCharges(Customer customer)
        {
            customer.CreditCharge = Math.Round((CreditPerc * customer.AnnualPremium) / 100, 2);
            customer.TotalPremium = customer.CreditCharge + customer.AnnualPremium;
            customer.AverageMonthly = customer.TotalPremium / 12;
            if ((customer.AverageMonthly % 1) == 0)
            {
                customer.InitialMonthly = customer.AverageMonthly;
                customer.OtherMonthly = customer.OtherMonthly;
            }
            else
            {
                customer.AverageMonthly = Math.Floor(customer.AverageMonthly * 100) / 100;
                customer.InitialMonthly = customer.TotalPremium - (customer.AverageMonthly * 11);
                customer.OtherMonthly = customer.AverageMonthly;
            }

            return customer;
        }
    }
}
