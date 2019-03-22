using Castle.Core;
using Castle.Core.Logging;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace StandardMakros.Components
{
    public sealed class Makro : IInitializable
    {
        public ILogger Logger { get; set; }
        public Application Application { get; set; }

        private readonly DateinameEinfuegenService dateinameEinfuegen;
        private readonly SeiteDruckenService seiteDrucken;

        public Makro(DateinameEinfuegenService dateinameEinfuegen, SeiteDruckenService seiteDrucken)
        {
            this.dateinameEinfuegen = dateinameEinfuegen;
            this.seiteDrucken = seiteDrucken;
        }

        public void InsertFilename(bool withPath)
        {
            dateinameEinfuegen.InsertFilename(Application.ActiveDocument, withPath);
        }

        public void PrintPage()
        {
            seiteDrucken.PrintPage(Application.ActiveDocument);
        }

        public void Initialize()
        {
            Logger.Info("Makro wird gestartet.");

            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptions;
        }

        private void UnhandledExceptions(object sender, UnhandledExceptionEventArgs e) {
            Logger.Error("", (Exception)e.ExceptionObject);
        }
    }
}
