using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Exer3.TempSensor
{
    interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}
