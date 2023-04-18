using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0.Models
{
    public class Electronic
    {
        private static int _code;
        private static string Code
        {
            get
            {
                _code++;
                var result = _code.ToString("0000");
                return result;
            }
        }

        public string ProductNo { get; set; }
        public string ModelName { get; set; }
        public Company CompanyName { get; set; }
        public DateTime DateOfMade { get; set; }
        public AuthMethod[] AuthMethods { get; set; }

        public Electronic()
        {
            string registryDate = DateTime.Now.ToString("yyMMdd");
            string code = Code;
            this.ProductNo = $"{registryDate}{code}";
        }
    }
}
