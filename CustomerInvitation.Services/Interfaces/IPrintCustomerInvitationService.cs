//-----------------------------------------------------------------------
// <copyright file="IPrintCustomerInvitationService.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace CustomerInvitation.Services.Interfaces
{
    using System.Collections.Generic;
    using CustomerInvitation.Domain.Models;

    /// <summary>
    /// Interface which defines the method for printing letters of customer
    /// </summary>
    public interface IPrintCustomerInvitationService
    {
        /// <summary>
        ///  PrintInvitationLetter method definition
        /// </summary>       
        void PrintInvitationLetter();
    }
}
