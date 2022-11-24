using NovemberQA.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NovemberQA.Hook
{
    [Binding]
    public sealed class Driver1 : Driver
    {
        

        [BeforeScenario]

        public void Setup()
        {
            //launch the browser
            Initialize();

        }


        [AfterScenario]
        public void TearDown()
        {

            Close();


        }
    }
}