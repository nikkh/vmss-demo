using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vmss_demo.Models
{
    public class ServerEnvironmentViewModel
    {
        public long WorkingSet { get; }
        public string ServerName { get; }
        public Hashtable EnvironmentVariables { get; }
        public ServerEnvironmentViewModel()
        {
            WorkingSet = System.Environment.WorkingSet;
            ServerName = System.Environment.MachineName;
            EnvironmentVariables = (Hashtable) System.Environment.GetEnvironmentVariables();
        }
    }
}