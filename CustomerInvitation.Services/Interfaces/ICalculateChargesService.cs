//-----------------------------------------------------------------------
// <copyright file="ICalculateChargesService.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CustomerInvitation.Services.Interfaces
{
    using System.Collections.Generic;
    using CustomerInvitation.Domain.Models;

    /// <summary>
    /// Interface which defines the methods for Calculating Charges of customer
    /// </summary>
    public interface ICalculateChargesService
    {
        /// <summary>
        /// Method definition for Calculating Charges of customer
        /// </summary>
        /// <param name="customer">parameter customer </param>
        /// <returns>returns customer</returns>
       Customer CalculateCharges(Customer customer);
    }
}
