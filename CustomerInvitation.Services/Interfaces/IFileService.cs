//-----------------------------------------------------------------------
// <copyright file="IFileService.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CustomerInvitation.Services.Interfaces
{
    using System.Collections.Generic;
    using CustomerInvitation.Domain.Models;

    /// <summary>
    /// Interface which defines the methods for reading and writing files
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Read File Method Definition
        /// </summary>
        /// <param name="location">parameter location</param>
        /// <returns>returns Customer</returns>
        List<Customer> ReadFile(string location);

        /// <summary>
        /// Write File Method Definition
        /// </summary>
        /// <param name="location">parameter location</param>
        /// <param name="customer">parameter customer</param>
        void WriteFile(string location, Customer customer);
    }
}
