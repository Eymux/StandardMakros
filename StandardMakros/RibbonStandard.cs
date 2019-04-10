using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using StandardMakros.Components;

namespace StandardMakros
{
    public partial class RibbonStandard
    {
        private Makro makro;

        private void RibbonStandard_Load(object sender, RibbonUIEventArgs e)
        {
            makro = Globals.ThisAddIn.Container.Resolve<Makro>();
        }

        private void PbDateinameEinfuegen_Click(object sender, RibbonControlEventArgs e)
        {
            bool withPath = (sender != pbWithoutPath);
            makro.InsertFilename(withPath);

            new MarkdownViewer.MarkdownViewerPanel().Show();
        }

        private void PbSeiteDrucken_Click(object sender, RibbonControlEventArgs e)
        {
            makro.PrintPage();
        }
    }
}
