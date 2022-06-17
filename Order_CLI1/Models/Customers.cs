using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_CLI.Models
{
    public class Customers
    {
        public string TC 
        {
            get; set;    //Model içerisinde bulunan property lere veri yazmak ve almak için kullanırız
        }
        public string Name
        {
            get; set;
        }
        public string Surname
        {
            get; set;
        }
        public string GSM
        {
            get; set;
        }

       
        public Customers(string tc, string name, string surname, string GSM)  //Constructorlar
        {
           
            this.TC = tc;
            this.Name = name;
            this.Surname = surname;
            this.GSM = GSM;
        }

    }
}
