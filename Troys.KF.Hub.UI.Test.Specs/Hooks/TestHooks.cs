using Autofac;
using Autofac.Features.ResolveAnything;
using OpenQA.Selenium;
using SpecFlow.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Troys.KK.Hub.UI.Test.Automation.Framework.Factories;

namespace Troys.KF.Hub.UI.Test.Specs.Hooks
{
    [Binding]
    public sealed class TestHooks
    {
        private static IWebDriver webDriver;

        [ScenarioDependencies]
        public static ContainerBuilder BeforeScenarioConfigContainer()
        {

            webDriver = WebDriverFactory.Create();
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterInstance<IWebDriver>(webDriver);
            containerBuilder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
            return containerBuilder;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Quit();
        }
    }
}
