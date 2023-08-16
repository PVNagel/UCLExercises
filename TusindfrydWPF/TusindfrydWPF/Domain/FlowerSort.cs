using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TusindfrydWPF.Domain
{
    public class FlowerSort
    {
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public int ProductionTime { get; set; }
        public int HalfLifeTime { get; set; }
        public int Size { get; set; }

        public FlowerSort(string name, string picturePath, int productionTime, int halfLifeTime, int size)
        {
            Name = name;
            PicturePath = picturePath;
            ProductionTime = productionTime;
            HalfLifeTime = halfLifeTime;
            Size = size;
        }

        public override string ToString()
        {
            return "Blomstersort: " + Name + "\nBilledesti: " + PicturePath + "\nProduktionstid: " + ProductionTime + "\nHalveringstid: " + HalfLifeTime + "\nStørrelse: " + Size;
        }
    }
}
