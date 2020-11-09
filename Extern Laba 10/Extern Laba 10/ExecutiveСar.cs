using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extern_Laba_10
{
    class ExecutiveСar : Car
    {
        public ExecutiveСar(string Name, int MaxSpeed) : base(Name, MaxSpeed) { }
        public override int Price()
        {
            return MaxSpeed * 250;
        }
        public override void UpdateModel()
        {
            MaxSpeed += 5;
        }
    }
}
