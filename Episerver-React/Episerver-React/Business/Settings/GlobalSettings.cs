﻿namespace Episerver_React.Business.Settings
{
    public class GlobalSettings
    {
        /// <summary>
        /// Custom UI hints
        /// </summary>
        public static class CustomUiHints
        {
            public const string TemplateModel = "TemplateModel";
        }

        /// <summary>
        /// Custom tags that can be used as Display Option inside a Content Area
        /// </summary>
        public static class ContentAreaTags
        {
            public const string HeroCta = "herocta";
            public const string CenteredTextBannerItem = "centeredtextbanneritem"; 
            public const string CenteredTextImageBannerItem = "centeredtextimagebanneritem";
            public const string SimpleCenteredText = "simplecenteredtext";
            public const string FooterCenteredText = "footercenteredtext";
            public const string FiveTiles = "tiles-5";
            public const string TwoTiles = "tiles-2";
        }

        /// <summary>
        /// Custom rendering tags used by developers
        /// </summary>
        public static class RenderingTags
        {
            public const string GlobalNavigationItem = "globalNavigationItem";
            public const string LogoCollectionItem = "logoCollectionItem";
            public const string GroupedTilesItem = "groupedTilesItem";
            public const string CheckboxLinkItem = "checkBoxListItem";
            public const string RegularLinkItem = "regularLinkItem";

        }
    }
}