using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_CLI.Models
{
    public enum Kind //Girilen karaktere göre karşılığı olan kelimeleri getirir
    {
        [Description("Yuvarlak Yaka")] //Ayrı yazabilmek için helper kullanarak description içerisinde yazılır
        YuvarlakYaka = 1,
        [Description("Bisiklet Yaka")]
        BisikletYaka,
        [Description("V Yaka")]
        VYaka,
        [Description("Polo Yaka")]
        PoloYaka
    }
}
