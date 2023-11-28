using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgGym.PrinterMonitor.Domain_Win.Interfaces
{
    public interface IAuthDomain
    {
        public DirectoryEntry GetEntry(string? path, string? username, string? password);
    }
}
