﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ProgGym.PrinterMonitor.Application.Interfaces;
using System.DirectoryServices;
using ProgGym.PrinterMonitor.Application;
using ProgGym.PrinterMonitor.Domain_Win.Interfaces;

namespace ProgGym.PrinterMonitor.Domain_Win.Services
{
    public class SearchDeviceService : ISearchDeviceService
    {
        private readonly MonitorSettings monitorSettings;
        private readonly IAuthDomain authDomain;
        private List<string?> printers = new List<string?>();
        
        public SearchDeviceService(MonitorSettings monitorSettings, IAuthDomain authDomain)
        {
            this.monitorSettings = monitorSettings;
            this.authDomain = authDomain;
        }

        public List<string?> GetPrinters()
        {
            DirectorySearcher searcher = new DirectorySearcher(this.authDomain.GetEntry(this.monitorSettings.DomainPath, 
                                                                                        this.monitorSettings.DomainUserName,
                                                                                        this.monitorSettings.DomainPassword));
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
