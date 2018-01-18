namespace ITSD_Start
{
    partial class RadForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.tileGroupElement1 = new Telerik.WinControls.UI.TileGroupElement();
            this.radTileElement1 = new Telerik.WinControls.UI.RadTileElement();
            this.radTileElement2 = new Telerik.WinControls.UI.RadTileElement();
            this.radTileElement3 = new Telerik.WinControls.UI.RadTileElement();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanorama1
            // 
            this.radPanorama1.CellSize = new System.Drawing.Size(200, 200);
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            this.tileGroupElement1});
            this.radPanorama1.Location = new System.Drawing.Point(0, 0);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.RowsCount = 2;
            this.radPanorama1.ScrollBarThickness = 36;
            this.radPanorama1.ShowGroups = true;
            this.radPanorama1.Size = new System.Drawing.Size(954, 471);
            this.radPanorama1.TabIndex = 0;
            this.radPanorama1.Text = "radPanorama1";
            this.radPanorama1.ThemeName = "TelerikMetroTouch";
            this.radPanorama1.Click += new System.EventHandler(this.radPanorama1_Click);
            // 
            // tileGroupElement1
            // 
            this.tileGroupElement1.CellSize = new System.Drawing.Size(200, 200);
            this.tileGroupElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tileGroupElement1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radTileElement1,
            this.radTileElement2,
            this.radTileElement3});
            this.tileGroupElement1.Name = "tileGroupElement1";
            this.tileGroupElement1.RowsCount = 2;
            this.tileGroupElement1.Text = "Data Entry";
            this.tileGroupElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tileGroupElement1.UseCompatibleTextRendering = false;
            this.tileGroupElement1.Click += new System.EventHandler(this.tileGroupElement1_Click);
            // 
            // radTileElement1
            // 
            this.radTileElement1.Name = "radTileElement1";
            this.radTileElement1.Text = "Customers";
            // 
            // radTileElement2
            // 
            this.radTileElement2.Name = "radTileElement2";
            this.radTileElement2.Row = 1;
            this.radTileElement2.Text = "Jobs";
            // 
            // radTileElement3
            // 
            this.radTileElement3.Column = 1;
            this.radTileElement3.Name = "radTileElement3";
            this.radTileElement3.Text = "Recyclers";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 471);
            this.Controls.Add(this.radPanorama1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "TelerikMetroTouch";
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.UI.TileGroupElement tileGroupElement1;
        private Telerik.WinControls.UI.RadTileElement radTileElement1;
        private Telerik.WinControls.UI.RadTileElement radTileElement2;
        private Telerik.WinControls.UI.RadTileElement radTileElement3;
    }
}
