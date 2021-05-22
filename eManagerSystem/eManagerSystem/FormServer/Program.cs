using eManagerSystem.Application.Catalog.Server;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace FormServer
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
         
        }
        private static void ConfigureServices(ServiceCollection services)
        {
          
            services.AddScoped<Form1>()
                .AddTransient<IServerService,ServerService>();
            services.AddScoped<Form2>()
                .AddTransient<IServerService, ServerService>();

        }
    }
}
