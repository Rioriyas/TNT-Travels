namespace Tourism_page
{
    partial class Adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminform));
            this.Userlabel = new System.Windows.Forms.Label();
            this.Pwdlabel = new System.Windows.Forms.Label();
            this.Usertext = new System.Windows.Forms.TextBox();
            this.Pwdtext = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Userlabel
            // 
            resources.ApplyResources(this.Userlabel, "Userlabel");
            this.Userlabel.BackColor = System.Drawing.Color.Transparent;
            this.Userlabel.Name = "Userlabel";
            // 
            // Pwdlabel
            // 
            resources.ApplyResources(this.Pwdlabel, "Pwdlabel");
            this.Pwdlabel.BackColor = System.Drawing.Color.Transparent;
            this.Pwdlabel.Name = "Pwdlabel";
            // 
            // Usertext
            // 
            this.Usertext.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.Usertext, "Usertext");
            this.Usertext.Name = "Usertext";
            // 
            // Pwdtext
            // 
            this.Pwdtext.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.Pwdtext, "Pwdtext");
            this.Pwdtext.Name = "Pwdtext";
            this.Pwdtext.UseSystemPasswordChar = true;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Submit, "Submit");
            this.Submit.ForeColor = System.Drawing.Color.Blue;
            this.Submit.Name = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.ForeColor = System.Drawing.Color.OrangeRed;
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Name = "label1";
            // 
            // Adminform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Pwdtext);
            this.Controls.Add(this.Usertext);
            this.Controls.Add(this.Pwdlabel);
            this.Controls.Add(this.Userlabel);
            this.Name = "Adminform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.Label Pwdlabel;
        private System.Windows.Forms.TextBox Usertext;
        private System.Windows.Forms.TextBox Pwdtext;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
    }
}

