using cdn_api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlActions
{
    public class PrintFromXl : IPrint
    {
        public void Print(int ApiVersion, string sqlFilter, string number)
        {
            try
            {
                var XLWydruk = new XLWydrukInfo_20220()
                {
                    Wersja = ApiVersion,
                    Zrodlo = 0,
                    Wydruk = 303,
                    Format = 6,
                    FiltrSQL = sqlFilter,
                    Urzadzenie = 3,  // Inna drukarka
                    DrukujDoPliku = 1,
                    PlikDocelowy = $"C:\\raporty\\plik{number}.pdf"
                };

                int lReturn = cdn_api.cdn_api.XLWykonajPodanyWydruk(XLWydruk);
                cdn_api.cdn_api.XLWykonajPodanyWydruk(XLWydruk);

                Console.WriteLine("Wynik: " + lReturn.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd wydruku: " + ex.Message);
            }
            finally
            {
                Console.WriteLine($"Wykonano {number}");
            }
        }
    }
}
