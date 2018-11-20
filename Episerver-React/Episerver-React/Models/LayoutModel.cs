using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Episerver_React.Models
{
    public class LayoutModel
    {
        // public SiteLogotypeBlock Logotype { get; set; }
        public IHtmlString LogotypeLinkUrl { get; set; }
        public bool HideHeader { get; set; }
        public bool HideFooter { get; set; }
    }
}