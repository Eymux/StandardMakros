using Word = Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;

namespace StandardMakros.Components
{
    public sealed class SeiteDruckenService
    {
        public ILogger Logger { get; set; }

        public void PrintPage(Word.Document doc)
        {
            Logger.Debug("SeiteDrucken wird ausgeführt.");
            doc.PrintOut(true, false, Word.WdPrintOutRange.wdPrintCurrentPage, Copies: "1", Pages: "1");
        }
    }
}
