using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using WhiteBookBusiness.Abstract;
using WhiteBookBusiness.Concrete;
using WhiteBookDataAccess.Abstract;
using WhiteBookDataAccess.Concrete;

namespace Whitebook.Business.DependencyResolvers.Autofac
{
    public class AutofaceBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainMenuManager>().As<IMainMenuService>().SingleInstance();
            builder.RegisterType<EfMainMenuDal>().As<IMainMenuDal>().SingleInstance();

            builder.RegisterType<ContentManager>().As<IContentService>().SingleInstance();
            builder.RegisterType<EfContentDal>().As<IContentDal>().SingleInstance();

            builder.RegisterType<ProjectManager>().As<IProjectService>().SingleInstance();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>().SingleInstance();

            builder.RegisterType<SubMenuManager>().As<ISubMenuService>().SingleInstance();
            builder.RegisterType<EfSubmenuDal>().As<ISubmenuDal>().SingleInstance();
        }
    }
}
