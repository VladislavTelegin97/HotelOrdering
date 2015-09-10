namespace HotelOrdering
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSkinEditor = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panel41 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.buttonStripLanguage = new System.Windows.Forms.ToolStripSplitButton();
            this.dEUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uKRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uKRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNextFloor = new System.Windows.Forms.Button();
            this.buttonPreviousFloor = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.buttonAbout);
            this.panel2.Controls.Add(this.buttonHelp);
            this.panel2.Controls.Add(this.buttonSkinEditor);
            this.panel2.Controls.Add(this.buttonConfirm);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // buttonAbout
            // 
            resources.ApplyResources(this.buttonAbout, "buttonAbout");
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            resources.ApplyResources(this.buttonHelp, "buttonHelp");
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonSkinEditor
            // 
            resources.ApplyResources(this.buttonSkinEditor, "buttonSkinEditor");
            this.buttonSkinEditor.Name = "buttonSkinEditor";
            this.buttonSkinEditor.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            resources.ApplyResources(this.buttonConfirm, "buttonConfirm");
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel41, "panel41");
            this.panel41.Name = "panel41";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.buttonStripLanguage});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            // 
            // buttonStripLanguage
            // 
            resources.ApplyResources(this.buttonStripLanguage, "buttonStripLanguage");
            this.buttonStripLanguage.DropDownButtonWidth = 10;
            this.buttonStripLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dEUToolStripMenuItem,
            this.rUSToolStripMenuItem,
            this.uKRToolStripMenuItem,
            this.uKRToolStripMenuItem1});
            this.buttonStripLanguage.Image = global::HotelOrdering.Properties.Resources.usa;
            this.buttonStripLanguage.Name = "buttonStripLanguage";
            this.buttonStripLanguage.ButtonClick += new System.EventHandler(this.buttonStripLanguage_ButtonClick);
            // 
            // dEUToolStripMenuItem
            // 
            this.dEUToolStripMenuItem.Image = global::HotelOrdering.Properties.Resources.usa;
            this.dEUToolStripMenuItem.Name = "dEUToolStripMenuItem";
            resources.ApplyResources(this.dEUToolStripMenuItem, "dEUToolStripMenuItem");
            this.dEUToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // rUSToolStripMenuItem
            // 
            this.rUSToolStripMenuItem.Image = global::HotelOrdering.Properties.Resources.deu;
            this.rUSToolStripMenuItem.Name = "rUSToolStripMenuItem";
            resources.ApplyResources(this.rUSToolStripMenuItem, "rUSToolStripMenuItem");
            this.rUSToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // uKRToolStripMenuItem
            // 
            this.uKRToolStripMenuItem.Image = global::HotelOrdering.Properties.Resources.rus;
            this.uKRToolStripMenuItem.Name = "uKRToolStripMenuItem";
            resources.ApplyResources(this.uKRToolStripMenuItem, "uKRToolStripMenuItem");
            this.uKRToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // uKRToolStripMenuItem1
            // 
            this.uKRToolStripMenuItem1.Image = global::HotelOrdering.Properties.Resources.ukr;
            this.uKRToolStripMenuItem1.Name = "uKRToolStripMenuItem1";
            resources.ApplyResources(this.uKRToolStripMenuItem1, "uKRToolStripMenuItem1");
            this.uKRToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // buttonNextFloor
            // 
            this.buttonNextFloor.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.buttonNextFloor, "buttonNextFloor");
            this.buttonNextFloor.Name = "buttonNextFloor";
            this.buttonNextFloor.UseVisualStyleBackColor = false;
            this.buttonNextFloor.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPreviousFloor
            // 
            this.buttonPreviousFloor.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.buttonPreviousFloor, "buttonPreviousFloor");
            this.buttonPreviousFloor.Name = "buttonPreviousFloor";
            this.buttonPreviousFloor.UseVisualStyleBackColor = false;
            this.buttonPreviousFloor.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel41);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonNextFloor);
            this.Controls.Add(this.buttonPreviousFloor);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveChanges);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPreviousFloor;
        private System.Windows.Forms.Button buttonNextFloor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSkinEditor;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSplitButton buttonStripLanguage;
        private System.Windows.Forms.ToolStripMenuItem dEUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uKRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uKRToolStripMenuItem1;
    }
}

