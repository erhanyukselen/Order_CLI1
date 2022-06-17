using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_CLI.Models
{
    public class Products
    {
        public Kind Kind
        {
            get; set;  //Model içerisinde bulunan property lere veri yazmak ve almak için kullanırız
        }
        public Color Color
        {
            get; set;
        }
        
        public Size Size
        {
            get; set;
        }
        public string Quantity
        {
            get; set;
        }
        public string TC
        {
            get; set;
        }


        public Products(Kind kind, Color color, Size size, string quantity, string tc) //Constructorlar
        {

            this.Kind = kind;
            this.Color = color;
            this.Size = size;
            this.Quantity = quantity;
            this.TC = tc;
        }
    }
}
