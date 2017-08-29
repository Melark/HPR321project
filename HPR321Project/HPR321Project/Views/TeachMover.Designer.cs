namespace HPR321Project.Views
{
    partial class TeachMover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachMover));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblTeachMover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(214, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 346);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(314, 500);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(299, 58);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Dare to Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblTeachMover
            // 
            this.lblTeachMover.AutoSize = true;
            this.lblTeachMover.BackColor = System.Drawing.Color.White;
            this.lblTeachMover.Font = new System.Drawing.Font("Segoe UI Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachMover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblTeachMover.Location = new System.Drawing.Point(110, 18);
            this.lblTeachMover.Name = "lblTeachMover";
            this.lblTeachMover.Size = new System.Drawing.Size(634, 106);
            this.lblTeachMover.TabIndex = 4;
            this.lblTeachMover.Text = "TeachMover UI";
            // 
            // TeachMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(879, 627);
            this.Controls.Add(this.lblTeachMover);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeachMover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblTeachMover;
    }
}

