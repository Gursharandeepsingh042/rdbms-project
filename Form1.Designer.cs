namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxcontactid = new System.Windows.Forms.TextBox();
            this.txtboxfirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxlastname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxcontactnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxaddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxGender = new System.Windows.Forms.ComboBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = " ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxcontactid
            // 
            this.txtboxcontactid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxcontactid.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcontactid.Location = new System.Drawing.Point(287, 173);
            this.txtboxcontactid.Name = "txtboxcontactid";
            this.txtboxcontactid.ReadOnly = true;
            this.txtboxcontactid.Size = new System.Drawing.Size(252, 38);
            this.txtboxcontactid.TabIndex = 9;
            // 
            // txtboxfirstname
            // 
            this.txtboxfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxfirstname.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxfirstname.Location = new System.Drawing.Point(287, 225);
            this.txtboxfirstname.Name = "txtboxfirstname";
            this.txtboxfirstname.Size = new System.Drawing.Size(252, 38);
            this.txtboxfirstname.TabIndex = 12;
            this.txtboxfirstname.TextChanged += new System.EventHandler(this.txtboxfirstname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = " ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtboxlastname
            // 
            this.txtboxlastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxlastname.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxlastname.Location = new System.Drawing.Point(287, 282);
            this.txtboxlastname.Name = "txtboxlastname";
            this.txtboxlastname.Size = new System.Drawing.Size(252, 38);
            this.txtboxlastname.TabIndex = 18;
            this.txtboxlastname.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = " ";
            // 
            // txtboxcontactnumber
            // 
            this.txtboxcontactnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxcontactnumber.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcontactnumber.Location = new System.Drawing.Point(287, 333);
            this.txtboxcontactnumber.Name = "txtboxcontactnumber";
            this.txtboxcontactnumber.Size = new System.Drawing.Size(252, 38);
            this.txtboxcontactnumber.TabIndex = 21;
            this.txtboxcontactnumber.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = " ";
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxaddress.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxaddress.Location = new System.Drawing.Point(287, 457);
            this.txtboxaddress.Multiline = true;
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(252, 88);
            this.txtboxaddress.TabIndex = 24;
            this.txtboxaddress.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Address";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 546);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 31);
            this.label11.TabIndex = 22;
            this.label11.Text = " ";
            // 
            // txtboxGender
            // 
            this.txtboxGender.FormattingEnabled = true;
            this.txtboxGender.Items.AddRange(new object[] {
            "Male",
            "Female ",
            "Others"});
            this.txtboxGender.Location = new System.Drawing.Point(287, 384);
            this.txtboxGender.Name = "txtboxGender";
            this.txtboxGender.Size = new System.Drawing.Size(252, 39);
            this.txtboxGender.TabIndex = 25;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(25, 395);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(95, 28);
            this.lblgender.TabIndex = 26;
            this.lblgender.Text = "Gender";
            this.lblgender.Click += new System.EventHandler(this.label12_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.Green;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.Transparent;
            this.addbutton.Location = new System.Drawing.Point(59, 659);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(91, 36);
            this.addbutton.TabIndex = 27;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Yellow;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearbutton.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.clearbutton.Location = new System.Drawing.Point(448, 659);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(91, 36);
            this.clearbutton.TabIndex = 28;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = false;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Red;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebutton.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Transparent;
            this.deletebutton.Location = new System.Drawing.Point(319, 659);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(91, 36);
            this.deletebutton.TabIndex = 29;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebutton.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.Transparent;
            this.updatebutton.Location = new System.Drawing.Point(180, 659);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(103, 36);
            this.updatebutton.TabIndex = 30;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(595, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 381);
            this.dataGridView1.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(590, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 26);
            this.label12.TabIndex = 32;
            this.label12.Text = "Search";
            // 
            // txtboxsearch
            // 
            this.txtboxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxsearch.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxsearch.Location = new System.Drawing.Point(673, 126);
            this.txtboxsearch.Name = "txtboxsearch";
            this.txtboxsearch.Size = new System.Drawing.Size(332, 30);
            this.txtboxsearch.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1072, 872);
            this.Controls.Add(this.txtboxsearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.txtboxGender);
            this.Controls.Add(this.txtboxaddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtboxcontactnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxlastname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxfirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxcontactid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxcontactid;
        private System.Windows.Forms.TextBox txtboxfirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxlastname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxcontactnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxaddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtboxGender;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxsearch;
    }
}

