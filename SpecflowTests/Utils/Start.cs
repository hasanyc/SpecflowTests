using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTests
{
    
    public class Start : Driver
    {
        [BeforeScenario]
        public void Setup()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
            
        }
    }
}
