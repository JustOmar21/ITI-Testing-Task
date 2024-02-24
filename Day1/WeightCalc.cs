using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealWeightCalc
{
    public class WeightCalc
    {
        public char gender;
        public double Height { get; set; }
        public char Gender { get { return gender; } set { gender = char.ToLower(value); } }
        public WeightCalc() { }
        public WeightCalc(double height, char Gender)
        {
            this.Height = height;
            this.Gender = char.ToLower(Gender);
        }

        public double GetIdealWeight()
        {
            switch (Gender)
            {
                case 'm':
                    return (Height - 100) - ((Height - 150) / 4);
                case 'w':
                    return (Height - 100) - ((Height - 150) / 2);
                default:
                    return 0;
            }
        }
    }
}
