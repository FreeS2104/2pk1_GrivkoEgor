using System;
using System.Collections.Generic;
using System.Text;

namespace pz_3_2sem
{
        class Compony
        {
            public string name;
            public int okpo;
            public DateTime dateOFRegister;

            public Compony(string name, int okpo, DateTime data)
            {
                this.name = name;
                this.okpo = okpo;
                this.dateOFRegister = data;

            }
            public void GetCompanyInfoo()
            {
                Console.WriteLine($"Организация {name}, под номером OKPO {okpo} была создана {dateOFRegister}");
            }
        }
    
}
