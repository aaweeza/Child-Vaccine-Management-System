namespace CHILD_VACCINATION_MANAGMENT_SYSTEM
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.viewappbtn = new System.Windows.Forms.Button();
            this.timeslotbtn = new System.Windows.Forms.Button();
            this.appointmentbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Child ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 309);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(280, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "DASHBOARD";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_btn.Font = new System.Drawing.Font("Satoshi Black", 15.25F, System.Drawing.FontStyle.Bold);
            this.logout_btn.Location = new System.Drawing.Point(666, 415);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(130, 46);
            this.logout_btn.TabIndex = 20;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // viewappbtn
            // 
            this.viewappbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewappbtn.Font = new System.Drawing.Font("Satoshi Black", 16F, System.Drawing.FontStyle.Bold);
            this.viewappbtn.Location = new System.Drawing.Point(433, 415);
            this.viewappbtn.Name = "viewappbtn";
            this.viewappbtn.Size = new System.Drawing.Size(227, 46);
            this.viewappbtn.TabIndex = 21;
            this.viewappbtn.Text = "View Appointments";
            this.viewappbtn.UseVisualStyleBackColor = false;
            this.viewappbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timeslotbtn
            // 
            this.timeslotbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeslotbtn.Font = new System.Drawing.Font("Satoshi Black", 15.25F, System.Drawing.FontStyle.Bold);
            this.timeslotbtn.Location = new System.Drawing.Point(29, 415);
            this.timeslotbtn.Name = "timeslotbtn";
            this.timeslotbtn.Size = new System.Drawing.Size(185, 46);
            this.timeslotbtn.TabIndex = 23;
            this.timeslotbtn.Text = "Time Slots";
            this.timeslotbtn.UseVisualStyleBackColor = false;
            this.timeslotbtn.Click += new System.EventHandler(this.timeslotbtn_Click);
            // 
            // appointmentbtn
            // 
            this.appointmentbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.appointmentbtn.Font = new System.Drawing.Font("Satoshi Black", 15.25F, System.Drawing.FontStyle.Bold);
            this.appointmentbtn.Location = new System.Drawing.Point(220, 415);
            this.appointmentbtn.Name = "appointmentbtn";
            this.appointmentbtn.Size = new System.Drawing.Size(207, 46);
            this.appointmentbtn.TabIndex = 22;
            this.appointmentbtn.Text = "Set Appointments";
            this.appointmentbtn.UseVisualStyleBackColor = false;
            this.appointmentbtn.Click += new System.EventHandler(this.appointmentbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(24, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pick Valid Time Slot:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 473);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeslotbtn);
            this.Controls.Add(this.appointmentbtn);
            this.Controls.Add(this.viewappbtn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Parent Dashboard";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button viewappbtn;
        private System.Windows.Forms.Button timeslotbtn;
        private System.Windows.Forms.Button appointmentbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}