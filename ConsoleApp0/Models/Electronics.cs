using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0.Models
{
    public class Electronics
    {
        private static Electronics instance;
        public static Electronics GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Electronics();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public List<Electronic> ElectronicList { get; set; }

        private Electronics() { }

        public Electronic FindByProductNo(string productNo)
        {
            Electronic? find = ElectronicList.Find(x => x.ProductNo == productNo);
            return find;
        }

        public Electronic[] GroupByCompanyName(Company company)
        {
            Electronic[] electronics = ElectronicList.FindAll(x => x.CompanyName == company).ToArray();
            return electronics;
        }

        public Electronic[] GroupByAuthMethod(AuthMethod authMethod)
        {
            Electronic[] electronics = ElectronicList.FindAll(x => x.AuthMethods.Contains(authMethod)).ToArray();
            return electronics;
        }
    }
}
