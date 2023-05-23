using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Foundation.Common.Models.Navigation
{
    [SitecoreType(TemplateId = "{6458DFCB-8418-4FFC-8A42-814A154121A3}", AutoMap = true)]
    public class NavigationMenuSection
    {
        [SitecoreField(FieldName = "Link")]
        public virtual NavigationItem Link { get; set; }
        [SitecoreField(FieldName = "Sub Items", Setting = SitecoreFieldSettings.InferType)]
        public virtual IEnumerable<NavigationItem> SubItems { get; set; }
        public bool HasSubItems => this.SubItems.Any();
        public bool HasActiveSubItems
        {
            get
            {
                var currentPageId = RenderingContext.Current.PageContext.Item.ID;
                if (HasSubItems) return SubItems.Where(x => x.ID == currentPageId).Any();
                return false;
            }
        }
        public bool IsActive(ID activeID)
        {
            if (HasSubItems) return SubItems.Where(x => x.ID == activeID).Any();
            return false;
        }
        public bool IsLinkable
        {
            get
            {
                return (Link != null && !string.IsNullOrWhiteSpace(Link.Url) && !string.IsNullOrWhiteSpace(Link.Title));
            }
        }
    }
}