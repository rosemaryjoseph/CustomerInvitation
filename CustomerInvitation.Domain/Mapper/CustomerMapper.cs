//-----------------------------------------------------------------------
// <copyright file="CustomerMapper.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CustomerInvitation.Domain.Mappers
{
    using CsvHelper.Configuration;
    using CustomerInvitation.Domain.Models;
   
    /// <summary>
    /// Customer Mapper class to map with the document fields
    /// </summary>
    public sealed class CustomerMapper : ClassMap<Customer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerMapper"/> class.
        /// </summary>
        public CustomerMapper()
        {
            Map(x => x.ID).Index(0);
            Map(x => x.Title).Index(1);
            Map(x => x.FirstName).Index(2);
            Map(x => x.Surname).Index(3);
            Map(x => x.ProductName).Index(4);
            Map(x => x.PaymentAmount).Index(5);
            Map(x => x.AnnualPremium).Index(6);
        }
    }
}
