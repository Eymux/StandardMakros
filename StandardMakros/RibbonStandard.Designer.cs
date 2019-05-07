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
            this.SeiteDrucken = this.Factory.CreateRibbonSplitButton();
            this.SeiteDruckenHilfe = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.DateinameEinfuegen = this.Factory.CreateRibbonSplitButton();
            this.WithoutPath = this.Factory.CreateRibbonButton();
            this.DateinameEinfuegenHelp = this.Factory.CreateRibbonButton();
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
            this.grpStandard.Items.Add(this.SeiteDrucken);
            this.grpStandard.Items.Add(this.separator1);
            this.grpStandard.Items.Add(this.DateinameEinfuegen);
            this.grpStandard.Label = "Standard";
            this.grpStandard.Name = "grpStandard";
            // 
            // SeiteDrucken
            // 
            this.SeiteDrucken.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SeiteDrucken.Items.Add(this.SeiteDruckenHilfe);
            this.SeiteDrucken.Label = "Seite Drucken";
            this.SeiteDrucken.Name = "SeiteDrucken";
            this.SeiteDrucken.OfficeImageId = "PrintMenu";
            this.SeiteDrucken.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SeiteDrucken_Click);
            // 
            // SeiteDruckenHilfe
            // 
            this.SeiteDruckenHilfe.Label = "Hilfe";
            this.SeiteDruckenHilfe.Name = "SeiteDruckenHilfe";
            this.SeiteDruckenHilfe.OfficeImageId = "Help";
            this.SeiteDruckenHilfe.ShowImage = true;
            this.SeiteDruckenHilfe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SeiteDruckenHilfe_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // DateinameEinfuegen
            // 
            this.DateinameEinfuegen.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.DateinameEinfuegen.Items.Add(this.WithoutPath);
            this.DateinameEinfuegen.Items.Add(this.DateinameEinfuegenHelp);
            this.DateinameEinfuegen.Label = "Dateiname einfügen";
            this.DateinameEinfuegen.Name = "DateinameEinfuegen";
            this.DateinameEinfuegen.OfficeImageId = "FieldInsert";
            this.DateinameEinfuegen.ScreenTip = "Dateiname einfügen";
            this.DateinameEinfuegen.SuperTip = "Fügt den Dateinamen des aktuellen Dokuments an die Eingabeposition ein.\r\n\r\nDas Do" +
    "kument muss zuerst gespeichert werden.";
            this.DateinameEinfuegen.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DateinameEinfuegen_Click);
            // 
            // WithoutPath
            // 
            this.WithoutPath.Label = "Ohne Pfad";
            this.WithoutPath.Name = "WithoutPath";
            this.WithoutPath.ShowImage = true;
            this.WithoutPath.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DateinameEinfuegen_Click);
            // 
            // DateinameEinfuegenHelp
            // 
            this.DateinameEinfuegenHelp.Label = "Hilfe";
            this.DateinameEinfuegenHelp.Name = "DateinameEinfuegenHelp";
            this.DateinameEinfuegenHelp.OfficeImageId = "Help";
            this.DateinameEinfuegenHelp.ShowImage = true;
            this.DateinameEinfuegenHelp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DateinameEinfuegenHelp_Click);
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
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton SeiteDrucken;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton DateinameEinfuegen;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton WithoutPath;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SeiteDruckenHilfe;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DateinameEinfuegenHelp;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonStandard RibbonStandard
        {
            get { return this.GetRibbon<RibbonStandard>(); }
        }
    }
}
