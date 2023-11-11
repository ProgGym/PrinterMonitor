using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgGym.PrinterMonitor.Application.Interfaces
{
    public interface ISearchDeviceService
    {
        public Task<List<string>> GetPrinters();
    }
}
