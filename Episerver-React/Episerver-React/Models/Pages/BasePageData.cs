using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Episerver_React.Business.Rendering;
using Episerver_React.Business.Settings;

namespace Episerver_React.Models.Pages
{
    [ContentType(DisplayName = "Base Page Data",
        GUID = "27aa6ad2-f3a5-4a35-8812-5ce4e402d1aa",
        Description = "Base page used when no display option or template is needed",
        AvailableInEditMode = false)]
    public abstract class BasePageData : PageData, ICustomCssInContentArea
    {
        #region SEO

        [Required]
        [CultureSpecific]
        [Display(
            Name = "Seo Title",
            Order = 10,
            GroupName = ContentEditorTabs.SeoDetails)]
        public virtual string SeoTitle { get; set; }

        [CultureSpecific]
        [Display(
            Name = "SEO Description",
            Order = 20,
            GroupName = ContentEditorTabs.SeoDetails)]
        [UIHint(UIHint.Textarea)]
        public virtual string SeoDescription { get; set; }

        [CultureSpecific]
        [Display(
            Name = "SEO Keywords",
            Order = 30,
            GroupName = ContentEditorTabs.SeoDetails)]
        [UIHint(UIHint.Textarea)]
        public virtual string SeoKeywords { get; set; }

        [Display(
          GroupName = ContentEditorTabs.SeoDetails,
          Order = 400)]
        [CultureSpecific]
        public virtual bool DisableIndexing { get; set; }
        #endregion

        #region Settings

        [Display(
       GroupName = SystemTabNames.Content,
       Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PageImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText
        {
            get
            {
                var teaserText = this.GetPropertyValue(p => p.TeaserText);

                // Use explicitly set teaser text, otherwise fall back to description
                return !string.IsNullOrWhiteSpace(teaserText)
                        ? teaserText
                        : SeoDescription;
            }
            set { this.SetPropertyValue(p => p.TeaserText, value); }
        }

        [Display(
       GroupName = SystemTabNames.Settings,
       Order = 200)]
        [CultureSpecific]
        public virtual bool HideSiteHeader { get; set; }

        [Display(
            GroupName = SystemTabNames.Settings,
            Order = 300)]
        [CultureSpecific]
        public virtual bool HideSiteFooter { get; set; }

        #endregion

        #region Helpers


        public virtual string ViewName
        {
            get { return this.GetOriginalType().Name; }
        }

        public string ContentAreaCssClass => "teaserblock";
        #endregion
    }
}