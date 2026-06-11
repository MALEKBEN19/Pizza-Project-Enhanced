namespace PizzaProjectEnhanced
{
    partial class OrderMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plSize = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.lpCrustType = new System.Windows.Forms.Panel();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPizzaPic = new System.Windows.Forms.PictureBox();
            this.imgPicPizza = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.plSize.SuspendLayout();
            this.lpCrustType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizzaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tomatos Pizza", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPizzaPic);
            this.panel1.Controls.Add(this.lpCrustType);
            this.panel1.Controls.Add(this.plSize);
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 352);
            this.panel1.TabIndex = 1;
            // 
            // plSize
            // 
            this.plSize.Controls.Add(this.rbLarge);
            this.plSize.Controls.Add(this.rbMedium);
            this.plSize.Controls.Add(this.rbSmall);
            this.plSize.Controls.Add(this.label2);
            this.plSize.Location = new System.Drawing.Point(20, 15);
            this.plSize.Name = "plSize";
            this.plSize.Size = new System.Drawing.Size(180, 195);
            this.plSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tomatos Pizza", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size?";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(61, 45);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(95, 29);
            this.rbSmall.TabIndex = 7;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(61, 97);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(108, 29);
            this.rbMedium.TabIndex = 8;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(61, 149);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(95, 29);
            this.rbLarge.TabIndex = 9;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // lpCrustType
            // 
            this.lpCrustType.Controls.Add(this.rbThickCrust);
            this.lpCrustType.Controls.Add(this.rbThinCrust);
            this.lpCrustType.Controls.Add(this.label3);
            this.lpCrustType.Location = new System.Drawing.Point(20, 216);
            this.lpCrustType.Name = "lpCrustType";
            this.lpCrustType.Size = new System.Drawing.Size(269, 131);
            this.lpCrustType.TabIndex = 10;
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(61, 97);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(173, 29);
            this.rbThickCrust.TabIndex = 8;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(61, 45);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(160, 29);
            this.rbThinCrust.TabIndex = 7;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tomatos Pizza", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crust Type?";
            // 
            // pbPizzaPic
            // 
            this.pbPizzaPic.Location = new System.Drawing.Point(336, 15);
            this.pbPizzaPic.Name = "pbPizzaPic";
            this.pbPizzaPic.Size = new System.Drawing.Size(221, 167);
            this.pbPizzaPic.TabIndex = 12;
            this.pbPizzaPic.TabStop = false;
            // 
            // imgPicPizza
            // 
            this.imgPicPizza.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPicPizza.ImageStream")));
            this.imgPicPizza.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPicPizza.Images.SetKeyName(0, "SmallPizza.png");
            // 
            // OrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(893, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(909, 535);
            this.MinimumSize = new System.Drawing.Size(909, 535);
            this.Name = "OrderMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderMenu";
            this.panel1.ResumeLayout(false);
            this.plSize.ResumeLayout(false);
            this.plSize.PerformLayout();
            this.lpCrustType.ResumeLayout(false);
            this.lpCrustType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizzaPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Panel lpCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbPizzaPic;
        private System.Windows.Forms.ImageList imgPicPizza;
    }
}