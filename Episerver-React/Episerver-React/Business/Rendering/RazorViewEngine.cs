using Episerver_React.Business.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Episerver_React.Business.Rendering
{
        /// <summary>
    /// Extend the default RazorViewEngine with additional view locations
    /// </summary>
    public class ViewEngine : RazorViewEngine
    {
        private static readonly string[] AdditionalPartialViewFormats = new[]
        {
            String.Concat(ViewLocations.BlockPath, "{0}.cshtml"),
            String.Concat(ViewLocations.PartialPath, "{0}.cshtml"),
            String.Concat(ViewLocations.DisplayTemplatesPath, "{0}.cshtml")
        };

        public static readonly string[] AdditionalPageViewFormats = new[]
        {
            String.Concat(ViewLocations.PagePath, "{0}.cshtml"),
        };

        public ViewEngine()
        {
            PartialViewLocationFormats = PartialViewLocationFormats.Union(AdditionalPartialViewFormats).ToArray();
            ViewLocationFormats = ViewLocationFormats.Union(AdditionalPageViewFormats).ToArray();
        }
    }
}