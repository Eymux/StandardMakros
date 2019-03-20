using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Castle.MicroKernel.Registration;
using Microsoft.Office.Interop.Word;
using Castle.Facilities.Logging;
using Castle.Services.Logging.Log4netIntegration;

namespace StandardMakros
{
    public partial class ThisAddIn
    {
        private WindsorContainer container;

        public WindsorContainer Container
        {
            get
            {
                return container;
            }
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public override void BeginInit()
        {
            base.BeginInit();
            container = new WindsorContainer();
            container.AddFacility<LoggingFacility>(f => f.LogUsing<Log4netFactory>().WithConfig("log4net.xml"));
            container.Install(FromAssembly.This());
            container.Register(Component.For<Application>().Instance(this.Application));
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
