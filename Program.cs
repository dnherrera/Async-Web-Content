using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncWebContent.Classes;
using AsyncWebContent.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace AsyncWebContent
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IHttpHandler, HttpHandler>();
            ServiceProvider = services.BuildServiceProvider();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1());
        }
    }
}
