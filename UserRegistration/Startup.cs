﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserRegistration.Startup))]
namespace UserRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
