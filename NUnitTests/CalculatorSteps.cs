using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Tests
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly bdd.BoringCalculator calculator = new bdd.BoringCalculator();
        private readonly List<double> _values = new List<double>();
        private double _result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int value)
        {
            _values.Add(value);
            Console.WriteLine(value);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Adding numbers!");
            Assert.AreEqual(2, _values.Count);
            _result = calculator.Add(_values[0], _values[1]);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _result);
        }
    }
}
