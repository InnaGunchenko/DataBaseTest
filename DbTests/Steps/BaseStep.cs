using BoDi;
using DBTestsAppProj.Models.Base;
using System;
using TechTalk.SpecFlow;

namespace DbTests
{
    [Binding]
    public class BaseSteps : TechTalk.SpecFlow.Steps
    {
        public IObjectContainer ObjectContainer { get; }

        public BaseSteps(IObjectContainer objectContainer)
        {
            this.ObjectContainer = objectContainer;
        }
    }
}
