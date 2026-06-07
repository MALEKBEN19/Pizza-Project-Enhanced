namespace PizzaProjectEnhanced
{
    partial class frmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lkGitHub = new System.Windows.Forms.LinkLabel();
            this.lkLinkedIn = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lkProgrammingAdvices = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Owner";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PizzaProjectEnhanced.Properties.Resources.Edited;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(560, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "GitHub : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "LinkedIn : ";
            // 
            // lkGitHub
            // 
            this.lkGitHub.AutoSize = true;
            this.lkGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkGitHub.LinkColor = System.Drawing.Color.Navy;
            this.lkGitHub.Location = new System.Drawing.Point(38, 134);
            this.lkGitHub.Name = "lkGitHub";
            this.lkGitHub.Size = new System.Drawing.Size(273, 20);
            this.lkGitHub.TabIndex = 3;
            this.lkGitHub.TabStop = true;
            this.lkGitHub.Text = "https://github.com/MALEKBEN19";
            this.lkGitHub.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.lkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkGitHub_LinkClicked);
            // 
            // lkLinkedIn
            // 
            this.lkLinkedIn.AutoSize = true;
            this.lkLinkedIn.BackColor = System.Drawing.Color.Transparent;
            this.lkLinkedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLinkedIn.LinkColor = System.Drawing.Color.Navy;
            this.lkLinkedIn.Location = new System.Drawing.Point(38, 267);
            this.lkLinkedIn.Name = "lkLinkedIn";
            this.lkLinkedIn.Size = new System.Drawing.Size(437, 20);
            this.lkLinkedIn.TabIndex = 4;
            this.lkLinkedIn.TabStop = true;
            this.lkLinkedIn.Text = "https://www.linkedin.com/in/abdelmalek-b-b5b323240/";
            this.lkLinkedIn.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.lkLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "School :";
            // 
            // lkProgrammingAdvices
            // 
            this.lkProgrammingAdvices.AutoSize = true;
            this.lkProgrammingAdvices.BackColor = System.Drawing.Color.Transparent;
            this.lkProgrammingAdvices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkProgrammingAdvices.LinkColor = System.Drawing.Color.Navy;
            this.lkProgrammingAdvices.Location = new System.Drawing.Point(38, 400);
            this.lkProgrammingAdvices.Name = "lkProgrammingAdvices";
            this.lkProgrammingAdvices.Size = new System.Drawing.Size(267, 20);
            this.lkProgrammingAdvices.TabIndex = 5;
            this.lkProgrammingAdvices.TabStop = true;
            this.lkProgrammingAdvices.Text = "https://programmingadvices.com";
            this.lkProgrammingAdvices.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.lkProgrammingAdvices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkProgrammingAdvices_LinkClicked);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(894, 497);
            this.Controls.Add(this.lkProgrammingAdvices);
            this.Controls.Add(this.lkLinkedIn);
            this.Controls.Add(this.lkGitHub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 536);
            this.MinimumSize = new System.Drawing.Size(910, 536);
            this.Name = "frmContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lkGitHub;
        private System.Windows.Forms.LinkLabel lkLinkedIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lkProgrammingAdvices;
    }
}