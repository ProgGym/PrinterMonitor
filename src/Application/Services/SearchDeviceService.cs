using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProgGym.PrinterMonitor.Application.Services
{
    public class SearchDeviceService
    {
        private readonly MonitorSettings _monitorSettings;

        public SearchDeviceService(MonitorSettings monitorSettings)
        {
            _monitorSettings = monitorSettings;
        }

        //static void Main(string[] args)
        //{
        //    List<string> printers = new List<string>();
        //    string subnet = "192.168.1.";
        //    for (int i = 1; i < 255; i++)
        //    {
        //        string ip = subnet + i.ToString();
        //        Ping ping = new Ping();
        //        PingReply pingReply = ping.Send(ip, 1000);
        //        if (pingReply.Status == IPStatus.Success)
        //        {
        //            try
        //            {
        //                IPHostEntry host = Dns.GetHostEntry(ip);
        //                if (host != null)
        //                {
        //                    foreach (IPAddress address in host.AddressList)
        //                    {
        //                        if (address.AddressFamily == AddressFamily.InterNetwork)
        //                        {
        //                            string printerName = GetPrinterName(address.ToString());
        //                            if (!string.IsNullOrEmpty(printerName))
        //                            {
        //                                printers.Add(printerName);
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //    }

        //    if (printers.Count > 0)
        //    {
        //        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Printers;Integrated Security=True";
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            foreach (string printer in printers)
        //            {
        //                string query = "INSERT INTO Printers (Name) VALUES (@Name)";
        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    command.Parameters.AddWithValue("@Name", printer);
        //                    command.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //    }
        //}

        //static string GetPrinterName(string ipAddress)
        //{
        //    string printerName = null;
        //    string uri = "http://" + ipAddress + "/dnssd/mfpdiscovery";
        //    try
        //    {
        //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        //        request.Timeout = 1000;
        //        request.Method = "GET";
        //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //        if (response.StatusCode == HttpStatusCode.OK)
        //        {
        //            using (System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream()))
        //            {
        //                string responseText = reader.ReadToEnd();
        //                int start = responseText.IndexOf("name=") + 5;
        //                int end = responseText.IndexOf(";", start);
        //                printerName = responseText.Substring(start, end - start);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return printerName;
        //}
    }
}
