namespace CHILD_VACCINATION_MANAGMENT_SYSTEM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.doctorradio = new System.Windows.Forms.RadioButton();
            this.parentlogin = new System.Windows.Forms.RadioButton();
            this.login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(264, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // doctorradio
            // 
            this.doctorradio.AutoSize = true;
            this.doctorradio.BackColor = System.Drawing.Color.Transparent;
            this.doctorradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorradio.ForeColor = System.Drawing.Color.Navy;
            this.doctorradio.Location = new System.Drawing.Point(210, 353);
            this.doctorradio.Name = "doctorradio";
            this.doctorradio.Size = new System.Drawing.Size(164, 29);
            this.doctorradio.TabIndex = 1;
            this.doctorradio.TabStop = true;
            this.doctorradio.Text = "Doctor Login";
            this.doctorradio.UseVisualStyleBackColor = false;
            this.doctorradio.CheckedChanged += new System.EventHandler(this.doctorradio_CheckedChanged);
            // 
            // parentlogin
            // 
            this.parentlogin.AutoSize = true;
            this.parentlogin.BackColor = System.Drawing.Color.Transparent;
            this.parentlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentlogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.parentlogin.Location = new System.Drawing.Point(410, 353);
            this.parentlogin.Name = "parentlogin";
            this.parentlogin.Size = new System.Drawing.Size(164, 29);
            this.parentlogin.TabIndex = 2;
            this.parentlogin.TabStop = true;
            this.parentlogin.Text = "Parent Login";
            this.parentlogin.UseVisualStyleBackColor = false;
            this.parentlogin.CheckedChanged += new System.EventHandler(this.parentlogin_CheckedChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.PaleTurquoise;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.MidnightBlue;
            this.login.Location = new System.Drawing.Point(270, 389);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(239, 49);
            this.login.TabIndex = 3;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.parentlogin);
            this.Controls.Add(this.doctorradio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton doctorradio;
        private System.Windows.Forms.RadioButton parentlogin;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}