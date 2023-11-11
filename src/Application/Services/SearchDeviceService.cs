using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using ProgGym.PrinterMonitor.Application.Interfaces;

namespace ProgGym.PrinterMonitor.Application.Services
{
    public class SearchDeviceService : ISearchDeviceService
    {
        private readonly MonitorSettings _monitorSettings;

        public SearchDeviceService(MonitorSettings monitorSettings)
        {
            _monitorSettings = monitorSettings;
        }

        public async Task <List<string>> GetPrinters()
        {
            List<string> printers = new List<string>();
            DirectoryEntry root = new(_monitorSettings.DomainPath,
                                      _monitorSettings.DomainUserName,
                                      _monitorSettings.DomainPassword);

            DirectorySearcher searcher = new DirectorySearcher(root);
            searcher.Filter = "(objectClass=printQueue)";
            searcher.PropertiesToLoad.Add("cn");
            foreach (SearchResult result in searcher.FindAll())
            {
                printers.Add(result.Properties["cn"][0].ToString());
            }
            return printers;
        }
    }
}
