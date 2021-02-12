//-----------------------------------------------------------------------
// <copyright file="PrintCustomerInvitationService.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace CustomerInvitation.Services.Services
{
    using System;    
    using System.Configuration;
    using CustomerInvitation.Domain.Models;
    using CustomerInvitation.Services.Interfaces;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Customer service class for printing Invitation letters
    /// </summary>
    public class PrintCustomerInvitationService : IPrintCustomerInvitationService
    {
        /// <summary>
        /// constant fileReadPath
        /// </summary>
        private const string FileReadPath = @"C:\Users\Eldho Chacko\source\repos\CustomerInvitation\CustomerInvitation.Services\Customer.csv";

        /// <summary>
        /// constant fileWritePath
        /// </summary>
        private const string FileWritePath = @"C:\Users\Eldho Chacko\source\repos\CustomerInvitation\Invitation\";

        /// <summary>
        /// readonly object of ICalculateService
        /// </summary>
        private readonly ICalculateChargesService calcService;

        /// <summary>
        /// readonly object of IFileService
        /// </summary>
        private readonly IFileService fileService;

        /// <summary>
        /// readonly logger object 
        /// </summary>
        private readonly ILogger<PrintCustomerInvitationService> logger;
                
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintCustomerInvitationService"/> class.
        /// </summary>
        /// <param name="objcalcService">parameter of ICalculateService</param>
        /// <param name="objfileService">parameter IFileService</param>
        /// <param name="logger">parameter logger</param>
        public PrintCustomerInvitationService(ICalculateChargesService objcalcService, IFileService objfileService, ILogger<PrintCustomerInvitationService> logger)
        {
            this.calcService = objcalcService;
            this.fileService = objfileService;
            this.logger = logger;
        }

        /// <summary>
        /// PrintInvitationLetter implementation
        /// </summary>    
        public void PrintInvitationLetter()
        {
            try
            {
                var resultData = this.fileService.ReadFile(FileReadPath);
                foreach (Customer cust in resultData)
                {
                    var customerData = this.CalculateCharges(cust);
                    this.fileService.WriteFile(FileWritePath, customerData);
                }
            }
            catch (Exception ex)
            {
                this.logger.LogInformation(ex.Message);
            }
        }

        /// <summary>
        /// Calculate Charges Method
        /// </summary>
        /// <param name="resultData">parameter resultData</param>
        /// <returns>returns customer</returns>
        public Customer CalculateCharges(Customer resultData)
        {
            var records = new Customer();
            try
            {
                records = this.calcService.CalculateCharges(resultData);
            }
            catch (Exception ex)
            {
                this.logger.LogInformation(ex.Message);
            }

            return records;
        }
    }
}
