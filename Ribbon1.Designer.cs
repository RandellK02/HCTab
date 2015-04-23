namespace HCTab
{
    partial class HCRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public HCRibbon()
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
            this.hcTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnskypeNotify = this.Factory.CreateRibbonButton();
            this.hcTab.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // hcTab
            // 
            this.hcTab.Groups.Add(this.group1);
            this.hcTab.Label = "HC Tab";
            this.hcTab.Name = "hcTab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnskypeNotify);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // btnskypeNotify
            // 
            this.btnskypeNotify.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnskypeNotify.Description = "Notify via email when a contact becomes available.";
            this.btnskypeNotify.Image = global::HCTab.Properties.Resources.Skype;
            this.btnskypeNotify.Label = "Skype Notify";
            this.btnskypeNotify.Name = "btnskypeNotify";
            this.btnskypeNotify.ShowImage = true;
            this.btnskypeNotify.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnskypeNotify_Click);
            // 
            // HCRibbon
            // 
            this.Name = "HCRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.hcTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.hcTab.ResumeLayout(false);
            this.hcTab.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab hcTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnskypeNotify;
    }

    partial class ThisRibbonCollection
    {
        internal HCRibbon Ribbon1
        {
            get { return this.GetRibbon<HCRibbon>(); }
        }
    }
}
