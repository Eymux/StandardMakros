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
    public sealed class DateinameEinfuegenService
    {
        public ILogger Logger { get; set; }

        public void InsertFilename(Word.Document doc, bool withPath)
        {
            Logger.Debug("InsertFilename wird ausgeführt.");
            var rng = doc.Application.Selection.Range;
            var field = doc.Fields.Add(rng, Word.WdFieldType.wdFieldFileName, (withPath) ? "\\p" : "");
        }
    }

}
