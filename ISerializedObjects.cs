using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlPrinterUserController
{
    public interface ISerializedObjects
    {
        string ServerName { get; set; }
        string DbName { get; set; }
        string User { get; set; }
        string Password { get; set; }
    }
}
