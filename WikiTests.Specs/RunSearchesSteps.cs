using System;
using TechTalk.SpecFlow;

namespace WikiTests.Specs
{
    [Binding]
    public class RunSearchesSteps
    {
        [Given(@"I have navigated to the Wikipedia home page")]
        public void GivenIHaveNavigatedToTheWikipediaHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search ""(.*)""")]
        public void WhenISearch(string searchTerm)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I search ""(.*)""")]
        public void WhenISearchTaco()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the correct information page loads")]
        public void ThenTheCorrectInformationPageLoads()
        {
            ScenarioContext.Current.Pending();
        } 

        [Then(@"the ""(.*)"" information page loads")]
        public void ThenTheTacoInformationPageLoads()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
