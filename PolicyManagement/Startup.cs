﻿using Microsoft.Owin;
using Ninject;
using Owin;
using PolicyManagement.Utilis;

[assembly: OwinStartupAttribute(typeof(PolicyManagement.Startup))]
namespace PolicyManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
