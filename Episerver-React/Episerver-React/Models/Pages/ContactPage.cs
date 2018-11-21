using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using Episerver_React.Business.Rendering;

namespace Episerver_React.Models.Pages
{
    [ContentType(DisplayName = "ContactPage", GUID = "22419812-9487-47bc-ab28-80bb6b86d321", Description = "")]
      public class ContactPage : BasePageData, IContainerPage
    {
        [Display(GroupName = Global.GroupNames.Contact)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(GroupName = Global.GroupNames.Contact)]
        public virtual string Phone { get; set; }

        [Display(GroupName = Global.GroupNames.Contact)]
        [EmailAddress]
        public virtual string Email { get; set; }
    }
}
