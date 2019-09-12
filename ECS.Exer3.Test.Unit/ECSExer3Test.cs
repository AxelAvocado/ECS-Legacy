using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Exer3.ECS;

namespace ECS.Exer3.Test.Unit
{
    [TestFixture]
    public class ECSExer3Test
    {
        private ECS.Exer3.ECS.ECS _uut;
        

        [SetUp]
        public void Setup()
        {
            _uut = new ECS.Exer3.ECS.ECS();
        }
    }
}
