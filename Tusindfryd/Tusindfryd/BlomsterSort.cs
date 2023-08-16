using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd
{
    public class BlomsterSort
    {
		public string Name { get; set; }
		public string Image { get; set; }
		public int ProductionTimeInDays { get; set; }
		public int DecayTime { get; set; }
		public int Size { get; set; }

		public BlomsterSort(string name, string image, int productionTimeInDays, int decayTime, int size)
		{
			Name = name;
			Image = image;
			ProductionTimeInDays = productionTimeInDays;
			DecayTime = decayTime;
			Size = size;
		}	

		public void etablerNyBlomsterSort(string name, string image, int productionTimeInDays, int decayTime, int size)
		{
            this.Name = name;
            this.Image = image;
            this.ProductionTimeInDays = productionTimeInDays;
            this.DecayTime = decayTime;
            this.Size = size;
        }

		public override string ToString()
		{
			return $"Name: {Name} Image: {Image} Productions time in days: {ProductionTimeInDays} Decaytime: {DecayTime} Size: {Size}";
		}
	}
}
