using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using Episerver_React.Business.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Episerver_React.Business.Initialization
{

    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class ViewEngineInitialization : IInitializableModule
    {
        // using Injected because constructor dependency doesn't seem to work (can't find ViewEngineInitialization)
        internal static Injected<TemplateResolver> _templateResolver;

        public void Initialize(InitializationEngine context)
        {
            //Add custom view engine allowing partials to be placed in additional locations
            //Note that we add it first in the list to optimize view resolving when using DisplayFor/PropertyFor
            ViewEngines.Engines.Insert(0, new ViewEngine());

            _templateResolver.Service.TemplateResolved += TemplateCoordinator.OnTemplateResolved;
        }

        public void Uninitialize(InitializationEngine context)
        {
            //remove the instance we added
            ViewEngines.Engines.RemoveAt(0);

            _templateResolver.Service.TemplateResolved -= TemplateCoordinator.OnTemplateResolved;
        }
    }
}