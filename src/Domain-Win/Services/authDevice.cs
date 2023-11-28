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
        public DirectoryEntry GetEntry(string? path, string? username, string? password) 
        {
            DirectoryEntry root = new DirectoryEntry(path, username, password);
            return root;
        }

        
    }
}
