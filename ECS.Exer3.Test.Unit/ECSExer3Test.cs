using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Exer3.Test.Unit
{
    [TestFixture]
    public class ECSExer3Test
    {
        private Cal.Calculat uut;


        [SetUp]
        public void Setup()
        {
            _uut = new Cal.Calculator();
        }
    }
}
