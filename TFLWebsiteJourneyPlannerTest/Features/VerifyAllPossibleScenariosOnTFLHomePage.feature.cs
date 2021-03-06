// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TFLWebsiteJourneyPlannerTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("VerifyAllPossibleScenariosOnTFLHomePage")]
    public partial class VerifyAllPossibleScenariosOnTFLHomePageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VerifyAllPossibleScenariosOnTFLHomePage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "VerifyAllPossibleScenariosOnTFLHomePage", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that widget is unable to plan a journey if no locations are entered into t" +
            "he widget on TFL site")]
        [NUnit.Framework.TestCaseAttribute("", "", null)]
        [NUnit.Framework.TestCaseAttribute("123", "456", null)]
        public virtual void VerifyThatWidgetIsUnableToPlanAJourneyIfNoLocationsAreEnteredIntoTheWidgetOnTFLSite(string from, string to, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that widget is unable to plan a journey if no locations are entered into t" +
                    "he widget on TFL site", null, exampleTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("Navigate to home page of the TFL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When(string.Format("Enter any value in \"{0}\" from field", from), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.And(string.Format("Enter any value in \"{0}\" to field", to), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.Then(string.Format("Validate that widget is unable to plan a journey as incorrect locations \"{0}\",\"{1" +
                        "}\" are entered into the widget on TFL site", from, to), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that widget is able to plan a journey if correct locations are entered int" +
            "o the widget on TFL site")]
        [NUnit.Framework.TestCaseAttribute("East India DLR Station", "Westferry DLR Station", "New", null)]
        public virtual void VerifyThatWidgetIsAbleToPlanAJourneyIfCorrectLocationsAreEnteredIntoTheWidgetOnTFLSite(string from, string to, string journeyType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that widget is able to plan a journey if correct locations are entered int" +
                    "o the widget on TFL site", null, exampleTags);
#line 16
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
 testRunner.Given("Navigate to home page of the TFL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When(string.Format("Enter any value in \"{0}\" from field", from), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.And(string.Format("Enter any value in \"{0}\" to field", to), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then(string.Format("Validate that widget is able to plan a journey as correct locations \"{0}\",\"{1}\",\"" +
                        "{2}\" are entered into the widget on TFL site", from, to, journeyType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that widget is able to plan a journey after editing the locations into the" +
            " widget on TFL site")]
        [NUnit.Framework.TestCaseAttribute("123", "456", "East India DLR Station", "Westferry DLR Station", "Edited", null)]
        public virtual void VerifyThatWidgetIsAbleToPlanAJourneyAfterEditingTheLocationsIntoTheWidgetOnTFLSite(string from, string to, string editedFrom, string editedTo, string journeyType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that widget is able to plan a journey after editing the locations into the" +
                    " widget on TFL site", null, exampleTags);
#line 28
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 30
 testRunner.Given("Navigate to home page of the TFL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.When(string.Format("Enter any value in \"{0}\" from field", from), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.And(string.Format("Enter any value in \"{0}\" to field", to), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And(string.Format("Widget is unable to plan a journey as incorrect locations \"{0}\",\"{1}\",\"{2}\",\"{3}\"" +
                        " are entered into the widget on TFL site", from, to, editedFrom, editedTo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then(string.Format("Validate that widget is able to plan a journey as correct locations \"{0}\",\"{1}\",\"" +
                        "{2}\" are entered into the widget on TFL site", editedFrom, editedTo, journeyType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that widget is able to display a list of recently planned journeys after c" +
            "reating and editing the locations into the widget on TFL site")]
        [NUnit.Framework.TestCaseAttribute("East India DLR Station", "Beckton DLR Station", "New", "East India DLR Station", "Westferry DLR Station", "Edited", null)]
        public virtual void VerifyThatWidgetIsAbleToDisplayAListOfRecentlyPlannedJourneysAfterCreatingAndEditingTheLocationsIntoTheWidgetOnTFLSite(string from, string to, string journeyType, string editedFrom, string editedTo, string journeyType2, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that widget is able to display a list of recently planned journeys after c" +
                    "reating and editing the locations into the widget on TFL site", null, exampleTags);
#line 40
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 42
 testRunner.Given("Navigate to home page of the TFL", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.When(string.Format("Enter any value in \"{0}\" from field", from), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.And(string.Format("Enter any value in \"{0}\" to field", to), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then(string.Format("Validate that widget is able to plan a journey as correct locations \"{0}\",\"{1}\",\"" +
                        "{2}\" are entered into the widget on TFL site", from, to, journeyType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And(string.Format("Edit the to and from fields \"{0}\",\"{1}\" and enter into the widget on TFL site", editedFrom, editedTo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And(string.Format("Validate that widget is able to plan a journey as correct locations \"{0}\",\"{1}\",\"" +
                        "{2}\" are entered into the widget on TFL site", editedFrom, editedTo, journeyType2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And(string.Format("Verify the recent tab on plan a journey page contains detail \"{0}\",\"{1}\" of recen" +
                        "tly planned journey", editedFrom, editedTo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

