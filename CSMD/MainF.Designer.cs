﻿namespace CSMD
{
    partial class MainF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.consoleTB = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.infoTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.compileTSSB = new System.Windows.Forms.ToolStripSplitButton();
            this.codeSFD = new System.Windows.Forms.SaveFileDialog();
            this.settingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tss = new System.Windows.Forms.ToolStripSeparator();
            this.spamTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleTB
            // 
            this.consoleTB.AcceptsTab = true;
            this.consoleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTB.AutoCompleteCustomSource.AddRange(new string[] {
            "System",
            "System.Collection.Generic"});
            this.consoleTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.consoleTB.BackColor = System.Drawing.Color.Black;
            this.consoleTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTB.ForeColor = System.Drawing.Color.Lime;
            this.consoleTB.Location = new System.Drawing.Point(0, 0);
            this.consoleTB.MaxLength = 2147483647;
            this.consoleTB.Multiline = true;
            this.consoleTB.Name = "consoleTB";
            this.consoleTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleTB.Size = new System.Drawing.Size(464, 256);
            this.consoleTB.TabIndex = 0;
            this.consoleTB.Text = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Syste" +
    "m.Text;\r\n\r\nnamespace Foo {\r\n\tpublic class Bar {\r\n\t\tstatic void Main(string[] arg" +
    "s) {\r\n\t\t\t\r\n\t\t}\r\n\t}\r\n}";
            this.consoleTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleTB_KeyDown);
            this.consoleTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.consoleTB_KeyUp);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoTSSL,
            this.compileTSSB});
            this.statusStrip.Location = new System.Drawing.Point(0, 259);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(464, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // infoTSSL
            // 
            this.infoTSSL.Name = "infoTSSL";
            this.infoTSSL.Size = new System.Drawing.Size(85, 17);
            this.infoTSSL.Text = "CSMD Version ";
            // 
            // compileTSSB
            // 
            this.compileTSSB.Image = global::CSMD.Properties.Resources.play;
            this.compileTSSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compileTSSB.Name = "compileTSSB";
            this.compileTSSB.Size = new System.Drawing.Size(84, 20);
            this.compileTSSB.Text = "Compile";
            this.compileTSSB.ButtonClick += new System.EventHandler(this.compileTSSB_ButtonClick);
            // 
            // codeSFD
            // 
            this.codeSFD.Filter = "CST file|*.cst";
            // 
            // settingsTSMI
            // 
            this.settingsTSMI.Image = global::CSMD.Properties.Resources.settings;
            this.settingsTSMI.Name = "settingsTSMI";
            this.settingsTSMI.Size = new System.Drawing.Size(185, 22);
            this.settingsTSMI.Text = "Settings";
            this.settingsTSMI.Click += new System.EventHandler(this.settingsTSMI_Click);
            // 
            // saveTSMI
            // 
            this.saveTSMI.Image = global::CSMD.Properties.Resources.save;
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTSMI.Size = new System.Drawing.Size(185, 22);
            this.saveTSMI.Text = "Save code";
            this.saveTSMI.Click += new System.EventHandler(this.saveTSMI_Click);
            // 
            // tss
            // 
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(182, 6);
            // 
            // spamTSMI
            // 
            this.spamTSMI.Image = global::CSMD.Properties.Resources.world;
            this.spamTSMI.Name = "spamTSMI";
            this.spamTSMI.Size = new System.Drawing.Size(185, 22);
            this.spamTSMI.Text = "Visit author\'s website";
            this.spamTSMI.Click += new System.EventHandler(this.spamTSMI_Click);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.consoleTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainF";
            this.Text = "CSMD";
            this.Load += new System.EventHandler(this.MainF_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox consoleTB;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel infoTSSL;
        private System.Windows.Forms.ToolStripSplitButton compileTSSB;
        private System.Windows.Forms.ToolStripMenuItem settingsTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.SaveFileDialog codeSFD;
        private System.Windows.Forms.ToolStripSeparator tss;
        private System.Windows.Forms.ToolStripMenuItem spamTSMI;
    }
}

