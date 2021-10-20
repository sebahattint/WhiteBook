using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Business.Abstract;
using Whitebook.Business.Concrete;
using Whitebook.DataAccess.Abstract;
using Whitebook.DataAccess.Concrete;

namespace Whitebook.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
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
            builder.RegisterType<EfSubMenuDal>().As<ISubMenuDal>().SingleInstance();
        }
    }
}
