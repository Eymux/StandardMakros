namespace StandardMakros
{
    partial class RibbonStandard : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonStandard()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabLHM = this.Factory.CreateRibbonTab();
            this.grpStandard = this.Factory.CreateRibbonGroup();
            this.pbSeiteDrucken = this.Factory.CreateRibbonButton();
            this.pbDateinameEinfuegen = this.Factory.CreateRibbonSplitButton();
            this.pbWithoutPath = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.TabLHM.SuspendLayout();
            this.grpStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLHM
            // 
            this.TabLHM.Groups.Add(this.grpStandard);
            this.TabLHM.Label = "LHM";
            this.TabLHM.Name = "TabLHM";
            this.TabLHM.Position = this.Factory.RibbonPosition.BeforeOfficeId("TabHelp");
            // 
            // grpStandard
            // 
            this.grpStandard.Items.Add(this.pbSeiteDrucken);
            this.grpStandard.Items.Add(this.separator1);
            this.grpStandard.Items.Add(this.pbDateinameEinfuegen);
            this.grpStandard.Label = "Standard";
            this.grpStandard.Name = "grpStandard";
            // 
            // pbSeiteDrucken
            // 
            this.pbSeiteDrucken.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.pbSeiteDrucken.Label = "Seite Drucken";
            this.pbSeiteDrucken.Name = "pbSeiteDrucken";
            this.pbSeiteDrucken.OfficeImageId = "PrintMenu";
            this.pbSeiteDrucken.ShowImage = true;
            this.pbSeiteDrucken.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PbSeiteDrucken_Click);
            // 
            // pbDateinameEinfuegen
            // 
            this.pbDateinameEinfuegen.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.pbDateinameEinfuegen.Items.Add(this.pbWithoutPath);
            this.pbDateinameEinfuegen.Label = "Dateiname einfügen";
            this.pbDateinameEinfuegen.Name = "pbDateinameEinfuegen";
            this.pbDateinameEinfuegen.OfficeImageId = "FieldInsert";
            this.pbDateinameEinfuegen.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PbDateinameEinfuegen_Click);
            // 
            // pbWithoutPath
            // 
            this.pbWithoutPath.Label = "Ohne Pfad";
            this.pbWithoutPath.Name = "pbWithoutPath";
            this.pbWithoutPath.ShowImage = true;
            this.pbWithoutPath.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PbDateinameEinfuegen_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // RibbonStandard
            // 
            this.Name = "RibbonStandard";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.TabLHM);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonStandard_Load);
            this.TabLHM.ResumeLayout(false);
            this.TabLHM.PerformLayout();
            this.grpStandard.ResumeLayout(false);
            this.grpStandard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabLHM;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpStandard;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pbSeiteDrucken;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton pbDateinameEinfuegen;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pbWithoutPath;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonStandard RibbonStandard
        {
            get { return this.GetRibbon<RibbonStandard>(); }
        }
    }
}
