using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Episerver_React.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "84c434b0-ac3f-46d9-9342-5efad061d0cb", Description = "")]
    //[SiteImageUrl]
    public class StandardPage : BasePageData
    {
        [Display(
             GroupName = SystemTabNames.Content,
             Order = 310)]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}