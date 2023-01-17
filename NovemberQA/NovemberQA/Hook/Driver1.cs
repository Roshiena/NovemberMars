using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NovemberQA.Utilities;

namespace NovemberQA.Hook
{
    [Binding]
    public sealed class Driver1 : CommonDriver
    {

        
        [BeforeScenario]

        public void Setup()
        {
            
            Initialize();

        }



        
        [AfterScenario]
        public void TearDown()
        {

            Close();


        }

    }
}