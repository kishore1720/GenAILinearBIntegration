using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GenAIProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private static int A;
        private static int B;
        private static int C;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int a)
        {
            A = a;
            Console.WriteLine(A);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int b)
        {
            B = b;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            C = A + B;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(result.Equals(C));
            Console.WriteLine(C);
        }
    }
}