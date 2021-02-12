//-----------------------------------------------------------------------
// <copyright file="Customer.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace CustomerInvitation.Domain.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Customer class which defines the customer model
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the ID of the customer. 
        /// </summary>
        /// <value>The ID of the customer.</value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Title of the customer. 
        /// </summary>
        /// <value>The Title of the customer.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the FirstName of the customer. 
        /// </summary>
        /// <value>The FirstName of the customer.</value>        
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Surname of the customer. 
        /// </summary>
        /// <value>The Surname of the customer.</value>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the ProductName of the customer. 
        /// </summary>
        /// <value>The ProductName of the customer.</value>       
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the PaymentAmount of the customer. 
        /// </summary>
        /// <value>The PaymentAmount of the customer.</value>
        public decimal PaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the AnnualPremium of the customer. 
        /// </summary>
        /// <value>The AnnualPremium of the customer.</value>     
        public decimal AnnualPremium { get; set; }

        /// <summary>
        /// Gets or sets the CreditCharge of the customer. 
        /// </summary>
        /// <value>The CreditCharge of the customer.</value>
        public decimal CreditCharge { get; set; }

        /// <summary>
        /// Gets or sets the TotalPremium of the customer. 
        /// </summary>
        /// <value>The TotalPremium of the customer.</value>
        public decimal TotalPremium { get; set; }

        /// <summary>
        /// Gets or sets the AverageMonthly of the customer. 
        /// </summary>
        /// <value>The AverageMonthly of the customer.</value>
        public decimal AverageMonthly { get; set; }

        /// <summary>
        /// Gets or sets the InitialMonthly of the customer. 
        /// </summary>
        /// <value>The InitialMonthly of the customer.</value>
        public decimal InitialMonthly { get; set; }

        /// <summary>
        /// Gets or sets the OtherMonthly of the customer. 
        /// </summary>
        /// <value>The OtherMonthly of the customer.</value>
        public decimal OtherMonthly { get; set; }
    }
}
