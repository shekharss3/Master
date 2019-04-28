using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ScenarioTest
{
    [Binding]
   internal class Program
    {
        int c = 0, a = 0, b = 0;

        [Given(@"I have entered (.*) and (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int a, int b)
        {
            c = a + b;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
          //  ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int cc)
        {
            Assert.AreEqual(c,cc, "Sorry Not Equal.");
        }


    }
}
