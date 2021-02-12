//-----------------------------------------------------------------------
// <copyright file="FileService.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CustomerInvitation.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using CsvHelper;
    using CustomerInvitation.Domain.Mappers;
    using CustomerInvitation.Domain.Models;
    using CustomerInvitation.Services.Interfaces;

    /// <summary>
    /// Customer service class implements ICustomer service interface
    /// </summary>
    public class FileService : IFileService
    {
        /// <summary>
        /// Read File method implementation
        /// </summary>
        /// <param name="location">parameter location</param>
        /// <returns>returns Customer</returns>
        public List<Customer> ReadFile(string location)
        {
            var records = new List<Customer>();
            using (var reader = new StreamReader(location, Encoding.Default))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Context.RegisterClassMap<CustomerMapper>();
                records = csv.GetRecords<Customer>().ToList();
            }

            return records;
        }

        /// <summary>
        /// Write File method implementation
        /// </summary>
        /// <param name="location">parameter location</param>
        /// <param name="customer">returns Customer</param>
        public void WriteFile(string location, Customer customer)
        {
            string fileName;

            fileName = location + customer.FirstName + "_" + customer.Surname + "_" + "Invite.txt";
            //// Check if file already exists. If yes, delete it.     
            if (!File.Exists(fileName))
            {
                //// Creates a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    sw.WriteLine();
                    sw.WriteLine("FAO: " + customer.Title + " " + customer.FirstName + " " + customer.Surname);
                    sw.WriteLine();
                    sw.WriteLine("RE: Your Renewal");
                    sw.WriteLine();
                    sw.WriteLine("Dear " + customer.Title + " " + customer.Surname);
                    sw.WriteLine();
                    sw.WriteLine("We hereby invite you to renew your Insurance Policy, subject to the following terms.");
                    sw.WriteLine();
                    sw.WriteLine("Your chosen insurance product is " + customer.ProductName + ".");
                    sw.WriteLine();
                    sw.WriteLine("The amount payable to you in the event of a valid claim will be £" + customer.PaymentAmount + ".");
                    sw.WriteLine();
                    sw.WriteLine("Your annual premium will be £" + customer.AnnualPremium + ".");
                    sw.WriteLine();
                    sw.WriteLine("If you choose to pay by Direct Debit, we will add a credit charge of £" + customer.CreditCharge + ", bringing the total to");
                    sw.WriteLine("£" + customer.TotalPremium + ".This is payable by an initial payment of £" + customer.InitialMonthly + ", ");
                    sw.WriteLine("followed by 11 payments of £" + customer.OtherMonthly + " each.");
                    sw.WriteLine();
                    sw.WriteLine("Please get in touch with us to arrange your renewal by visiting https://www.regallutoncodingtest.co.uk/renew");
                    sw.WriteLine("or calling us on 01625 123456.");
                    sw.WriteLine();
                    sw.WriteLine("Kind Regards");
                    sw.WriteLine("Regal Luton");
                    Console.WriteLine("Invitation letter for customer " + customer.Title + " " + customer.FirstName + " " + customer.Surname + " generated successfully.");
                }
            }
            else
            {
                Console.WriteLine("Invitation letter for customer " + customer.Title + " " + customer.FirstName + " " + customer.Surname + " already generated.");
            }
        }
    }
}
