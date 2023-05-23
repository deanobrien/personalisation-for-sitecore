using DeanOBrien.Foundation.Common.Models.Navigation;
using DeanOBrien.Foundation.Common.Models.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Feature.Navigation.ViewModels
{
    public class PrimaryNavigationViewModel
    {
        public SiteDetails Site { get; set; }
        public NavigationMenu Menu { get; set; }
    }
}