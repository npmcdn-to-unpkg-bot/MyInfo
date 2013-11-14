﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Http.Routing;

//using NHibernate.Cfg;
//using NHibernate.Dialect;
//using NHibernate.Driver;
//using System.Reflection;

namespace MyWebApi
{
    public class Global : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // easy route template to get rsessources by the controller name : /controller
            GlobalConfiguration.Configuration.Routes.Add("default", new HttpRoute("{controller}"));

            // route which allows for submitting parameters
            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // nhibernate configuration does not work
            //var cfg = new Configuration();
            //cfg.DataBaseIntegration(x =>
            //{
            //    x.ConnectionStringName = "webDB1013";

            //});
            //cfg.AddAssembly(Assembly.GetExecutingAssembly());
            //var sessionFactory = cfg.BuildSessionFactory();
            //using (var session = sessionFactory.OpenSession())
            //using (var tx = session.BeginTransaction())
            //{
            //    var tasks = session.CreateCriteria<Models.Task>()
            //        .List<Models.Task>();

            //    foreach (var task in tasks)
            //    {
            //        Console.WriteLine(task.Name);
            //    }
            //    tx.Commit();
            // }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            // register http routes
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}