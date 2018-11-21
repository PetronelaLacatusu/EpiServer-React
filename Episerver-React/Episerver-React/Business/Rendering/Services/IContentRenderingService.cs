using EPiServer.DataAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Episerver_React.Business.Rendering.Services
{
    /// <summary>
    /// Service used to configure rendering for different IContentData items, that don't need a dedicated controller
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContentRenderingService
    {
        /// <summary>
        /// Gets the content type to create template models for
        /// </summary>
        /// <returns></returns>
        Type GetContentType();

        /// <summary>
        /// Gets available Template Models for this specific IContentData item
        /// </summary>
        /// <returns></returns>
        TemplateModel[] GetAvailableTemplates();
    }
}
