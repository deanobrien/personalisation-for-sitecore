using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using System.Web.Mvc;
using DeanOBrien.Foundation.Common.Models.Site;
using DeanOBrien.Feature.Content.ViewModels;
using DeanOBrien.Foundation.Common.Models.Content;
using DeanOBrien.Foundation.Common.Models.Content.Paramaters;

namespace DeanOBrien.Feature.Content.Controllers
{
    public class ContentController : Controller
    {
        private MvcContext _mvcContext;
        private SitecoreService _sitecoreService;
        private SiteDetails _Site;
        public ContentController()
        {
            _mvcContext = new MvcContext();
            _sitecoreService = new SitecoreService(_mvcContext.ContextItem.Database);
            _Site = _sitecoreService.GetItem<SiteDetails>(Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath).Parent);
        }
        public ActionResult Content()
        {
            var model = new RenderingModel();
            model.Initialize(RenderingContext.Current.Rendering);
            return View(model);
        }
        public ActionResult LeadContent()
        {
            var model = new RenderingModel();
            model.Initialize(RenderingContext.Current.Rendering);
            return View(model);
        }
        public ActionResult PageHeading()
        {
            var model = new RenderingModel();
            model.Initialize(RenderingContext.Current.Rendering);
            return View(model);
        }
        public ActionResult Image()
        {
            var model = new ImageViewModel();
            model.Site = _Site;
            model.Image = _mvcContext.GetContextItem<ImagePod>();
            return View(model); 
        }
        public ActionResult Jumbotron()
        {
            var model = new JumbotronViewModel();
            model.Site = _Site;
            model.DataSource = _mvcContext.GetDataSourceItem<Jumbotron>();
            model.Jumbotron = _mvcContext.GetContextItem<Jumbotron>();
            model.Parameters = _mvcContext.GetRenderingParameters<JumbotronParameters>();
            return View(model);
        }
        public ActionResult ColourDemo()
        {
            var model = new RenderingModel();
            model.Initialize(RenderingContext.Current.Rendering);
            return View(model);
        }
    }
}