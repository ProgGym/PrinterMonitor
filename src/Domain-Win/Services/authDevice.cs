using ProgGym.PrinterMonitor.Application;
using ProgGym.PrinterMonitor.Domain_Win.Interfaces;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgGym.PrinterMonitor.Domain_Win.Services
{
    public class AuthDevice: IAuthDomain
    {
        private readonly MonitorSettings _monitorSettings;

        public DirectoryEntry Root { get; private set; }

        public AuthDevice(MonitorSettings monitorSettings)
        {
            _monitorSettings = monitorSettings;

            Root = new DirectoryEntry(_monitorSettings.DomainPath, 
                                      _monitorSettings.DomainUserName, 
                                      _monitorSettings.DomainPassword);
        }
        
    }
}
