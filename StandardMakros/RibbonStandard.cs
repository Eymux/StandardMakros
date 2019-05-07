using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private void DateinameEinfuegen_Click(object sender, RibbonControlEventArgs e)
        {
            bool withPath = (sender != WithoutPath);
            makro.InsertFilename(withPath);
        }

        private void SeiteDrucken_Click(object sender, RibbonControlEventArgs e)
        {
            makro.PrintPage();
        }

        private void SeiteDruckenHilfe_Click(object sender, RibbonControlEventArgs e)
        {
            makro.ShowHelp("StandardMakros.help.SeiteDrucken.md");
        }

        private void DateinameEinfuegenHelp_Click(object sender, RibbonControlEventArgs e)
        {
            makro.ShowHelp("StandardMakros.help.DateinameEinfuegen.md");
        }
    }
}
