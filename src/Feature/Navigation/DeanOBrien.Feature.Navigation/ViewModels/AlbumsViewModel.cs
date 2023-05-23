using DeanOBrien.Foundation.Common.Models.Navigation;
using DeanOBrien.Foundation.Common.Models.Navigation.Paramaters;
using DeanOBrien.Foundation.Common.Models.Site;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeanOBrien.Feature.Navigation.ViewModels
{
    public class AlbumsViewModel
    {
        public SiteDetails Site { get; set; }
        public Album Album { get; set; }
        public Album DataSource { get; set; }
        public AlbumParameters Parameters { get; set; }
        public virtual IEnumerable<NavigationItem> NavigationItems {
            get
            {
                if (DataSource != null && DataSource.NavigationItems != null) return DataSource.NavigationItems;
                return Album.NavigationItems;
            }
        }
    }
}