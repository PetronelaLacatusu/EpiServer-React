using EPiServer.Core;
using EPiServer.DataAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Episerver_React.Business.Rendering.Services
{
    /// <summary>
    /// Base implementation of IContentRenderingService with generic to streamline implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseContentRenderingService<T> : IContentRenderingService where T : IContentData
    {
        public abstract TemplateModel[] GetAvailableTemplates();

        public Type GetContentType()
        {
            return typeof(T);
        }
    }
}