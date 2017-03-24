using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BNR_Website
{
    public class MvcApplication : HttpApplication
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MvcApplication));


        protected void Application_Start()
        {
            try
            {
                XmlConfigurator.Configure();
                ConfigureRegistrations();
            }
            catch(Exception ex)
            {
                log.Fatal("Application failed to start.", ex.InnerException);
                throw;
            }

        }

        protected void Session_Start(Object sender, EventArgs e)
        {
            Session["DasDevs"] = true;
            log.Error("hi");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                //if stuff is localhost only on session start do it here
            }
        }

        protected void Session_End(Object sender, EventArgs e)
        {
        }

        protected void Application_Error()
        {
            try
            {
                HttpException lastErrorWrapper = Server.GetLastError() as HttpException;
                Exception lastError = lastErrorWrapper;
                if (lastErrorWrapper.InnerException != null) lastError = lastErrorWrapper.InnerException;

                string lastErrorTypeName = lastError.GetType().ToString();
                string lastErrorMessage = lastError.Message;
                string lastErrorStackTrace = lastError.StackTrace;

                log.Error("Unhandled application exception. Error Type Name: " + lastErrorTypeName + Environment.NewLine +
                    "Error Message: " + lastErrorMessage + Environment.NewLine +
                    "Error Stack Trace: " + lastErrorStackTrace);
            }
            catch
            {
                log.Error("Application_Error Exception Unable to be logged");
            }

        }

        private static void ConfigureRegistrations()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
