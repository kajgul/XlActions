using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlPrinterUserController
{
    public class ConnectionSet : ISerializedObjects
    {
        public string ServerName { get; set; }
        public string DbName { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        //version is needed for XL Connection
        public int Version { get; set; }

    }
}
