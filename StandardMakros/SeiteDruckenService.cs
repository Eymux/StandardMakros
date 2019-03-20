using Word = Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardMakros.Components
{
    public sealed class SeiteDruckenService
    {
        public void PrintPage(Word.Document doc)
        {
            doc.PrintOut(true, false, Word.WdPrintOutRange.wdPrintCurrentPage, Copies: "1", Pages: "1");
        }
    }
}
