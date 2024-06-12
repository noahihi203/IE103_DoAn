using DoAnIE103.DTO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace DoAnIE103
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new flogin());

            /*RootOject rootOject = getAdress(10.8696993, 106.8031529);
            
            Console.WriteLine(rootOject.display_name);
            Console.ReadLine();*/
        }
        /*public static RootOject getAdress(double lat, double lon)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Mozilla/4.0(compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            webClient.Headers.Add("Referer", "https://www.microsoft.com");
            var jsonData = webClient.DownloadData("https://nominatim.openstreetmap.org/reverse?format=json&lat=" + lat + "&lon=" + lon);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RootOject));
            RootOject rootOject = (RootOject)ser.ReadObject(new MemoryStream(jsonData));

            return rootOject;
        }*/
    }
}