//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="RLG">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CustomerInvitation
{
    using System;
    using CustomerInvitation.Services.Interfaces;
    using CustomerInvitation.Services.Services;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Program Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry point of program
        /// </summary>
        public static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            //// do the printing of letters
            Console.WriteLine("Started generating invitation letters......");
            Console.WriteLine();

            var custService = serviceProvider.GetService<IPrintCustomerInvitationService>();
            custService.PrintInvitationLetter();

            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }

            Console.WriteLine();
            Console.WriteLine("Finished generating invitation letters......");
        }

        /// <summary>
        /// ConfigureServices method
        /// </summary>
        /// <param name="services">parameter services</param>
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                    .AddSingleton<ICalculateChargesService, CalculateChargesService>()
                    .AddSingleton<IFileService, FileService>()
                    .AddSingleton<IPrintCustomerInvitationService, PrintCustomerInvitationService>();
        }
    }
}
