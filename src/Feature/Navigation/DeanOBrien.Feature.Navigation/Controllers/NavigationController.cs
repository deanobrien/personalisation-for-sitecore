using DeanOBrien.Feature.Navigation.ViewModels;
using DeanOBrien.Foundation.Common.Models.Navigation;
using DeanOBrien.Foundation.Common.Models.Navigation.Paramaters;
using DeanOBrien.Foundation.Common.Models.Site;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeanOBrien.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        private MvcContext _mvcContext;
        private SitecoreService _sitecoreService;
        private SiteDetails _Site;

        public NavigationController()
        {
            _mvcContext = new MvcContext();
            _sitecoreService = new SitecoreService(_mvcContext.ContextItem.Database);
            _Site = _sitecoreService.GetItem<SiteDetails>("/sitecore/content/Personalisation Demo/");
        }
        public ActionResult PrimaryNavigation()
        {
            var model = new PrimaryNavigationViewModel();
            model.Site = _Site;
            model.Menu = _sitecoreService.GetItem<NavigationMenu>("/sitecore/content/Personalisation Demo/Shared Data/Navigation Items");
            return View(model);
        }
        public ActionResult PrimaryNavigationV2()
        {
            var model = new PrimaryNavigationViewModel();
            model.Site = _Site;
            model.Menu = _sitecoreService.GetItem<NavigationMenu>("/sitecore/content/Personalisation Demo/Shared Data/Navigation Items");
            return View(model);
        }
        public ActionResult Album()
        {
            var model = new AlbumsViewModel();
            model.Album = _mvcContext.GetContextItem<Album>();
            model.DataSource = _mvcContext.GetDataSourceItem<Album>();
            model.Parameters = _mvcContext.GetRenderingParameters<AlbumParameters>();
            return View(model);
        }
    }
}