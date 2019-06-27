namespace OMHASSEN
{
    partial class clientform
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NationalIdClientTxt = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewC = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameClientTxt = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneClientTxt = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_remove_Client = new System.Windows.Forms.Button();
            this.btn_add_Client = new System.Windows.Forms.Button();
            this.btn_save_Client = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "الرقم القومى";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "رقم التلفون";
            this.columnHeader3.Width = 200;
            // 
            // NationalIdClientTxt
            // 
            this.NationalIdClientTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalIdClientTxt.Location = new System.Drawing.Point(98, 37);
            this.NationalIdClientTxt.Margin = new System.Windows.Forms.Padding(5);
            this.NationalIdClientTxt.Name = "NationalIdClientTxt";
            this.NationalIdClientTxt.Size = new System.Drawing.Size(282, 33);
            this.NationalIdClientTxt.TabIndex = 114;
            this.NationalIdClientTxt.TextChanged += new System.EventHandler(this.NationalIdClientTxt_TextChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(445, 42);
            this.label40.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 22);
            this.label40.TabIndex = 113;
            this.label40.Text = "الرقم القومى";
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1043, -35);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 112;
            this.label1.Text = "بيانات العميل";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.panel1.Location = new System.Drawing.Point(-12, -22);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 15);
            this.panel1.TabIndex = 111;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listViewC
            // 
            this.listViewC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.listViewC.FullRowSelect = true;
            this.listViewC.Location = new System.Drawing.Point(203, 220);
            this.listViewC.Margin = new System.Windows.Forms.Padding(5);
            this.listViewC.MultiSelect = false;
            this.listViewC.Name = "listViewC";
            this.listViewC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewC.RightToLeftLayout = true;
            this.listViewC.Size = new System.Drawing.Size(1007, 279);
            this.listViewC.TabIndex = 108;
            this.listViewC.UseCompatibleStateImageBehavior = false;
            this.listViewC.View = System.Windows.Forms.View.Details;
            this.listViewC.SelectedIndexChanged += new System.EventHandler(this.listViewC_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "الأسم";
            this.columnHeader2.Width = 150;
            // 
            // NameClientTxt
            // 
            this.NameClientTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameClientTxt.Location = new System.Drawing.Point(802, 42);
            this.NameClientTxt.Margin = new System.Windows.Forms.Padding(5);
            this.NameClientTxt.Name = "NameClientTxt";
            this.NameClientTxt.Size = new System.Drawing.Size(294, 33);
            this.NameClientTxt.TabIndex = 104;
            this.NameClientTxt.TextChanged += new System.EventHandler(this.NameClientTxt_TextChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1145, 46);
            this.label41.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 22);
            this.label41.TabIndex = 103;
            this.label41.Text = "الأسم";
            this.label41.Click += new System.EventHandler(this.label41_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1040, -80);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 102;
            this.label2.Text = "بيانات المورد";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phoneClientTxt
            // 
            this.phoneClientTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneClientTxt.Location = new System.Drawing.Point(802, 143);
            this.phoneClientTxt.Margin = new System.Windows.Forms.Padding(5);
            this.phoneClientTxt.Name = "phoneClientTxt";
            this.phoneClientTxt.Size = new System.Drawing.Size(294, 33);
            this.phoneClientTxt.TabIndex = 110;
            this.phoneClientTxt.TextChanged += new System.EventHandler(this.phoneClientTxt_TextChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(1108, 143);
            this.label43.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(84, 22);
            this.label43.TabIndex = 109;
            this.label43.Text = "  رقم التلفون";
            this.label43.Click += new System.EventHandler(this.label43_Click);
            // 
            // btn_remove_Client
            // 
            this.btn_remove_Client.BackColor = System.Drawing.Color.DarkRed;
            this.btn_remove_Client.FlatAppearance.BorderSize = 0;
            this.btn_remove_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_Client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove_Client.Location = new System.Drawing.Point(20, 392);
            this.btn_remove_Client.Margin = new System.Windows.Forms.Padding(5);
            this.btn_remove_Client.Name = "btn_remove_Client";
            this.btn_remove_Client.Size = new System.Drawing.Size(172, 63);
            this.btn_remove_Client.TabIndex = 107;
            this.btn_remove_Client.Text = "حذف";
            this.btn_remove_Client.UseVisualStyleBackColor = false;
            this.btn_remove_Client.Click += new System.EventHandler(this.btn_remove_Client_Click);
            // 
            // btn_add_Client
            // 
            this.btn_add_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.btn_add_Client.FlatAppearance.BorderSize = 0;
            this.btn_add_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_Client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_Client.Location = new System.Drawing.Point(20, 251);
            this.btn_add_Client.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_Client.Name = "btn_add_Client";
            this.btn_add_Client.Size = new System.Drawing.Size(172, 63);
            this.btn_add_Client.TabIndex = 106;
            this.btn_add_Client.Text = "أضافة";
            this.btn_add_Client.UseVisualStyleBackColor = false;
            this.btn_add_Client.Click += new System.EventHandler(this.btn_add_Client_Click);
            // 
            // btn_save_Client
            // 
            this.btn_save_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.btn_save_Client.FlatAppearance.BorderSize = 0;
            this.btn_save_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_Client.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_Client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_Client.Location = new System.Drawing.Point(932, 540);
            this.btn_save_Client.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save_Client.Name = "btn_save_Client";
            this.btn_save_Client.Size = new System.Drawing.Size(282, 69);
            this.btn_save_Client.TabIndex = 105;
            this.btn_save_Client.Text = "حفظ";
            this.btn_save_Client.UseVisualStyleBackColor = false;
            this.btn_save_Client.Click += new System.EventHandler(this.btn_save_Client_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.panel2.Location = new System.Drawing.Point(-15, -66);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1285, 15);
            this.panel2.TabIndex = 101;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1139, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 116;
            this.label3.Text = "اضافه عميل";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.panel3.Location = new System.Drawing.Point(-126, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1497, 15);
            this.panel3.TabIndex = 115;
            // 
            // clientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 625);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NationalIdClientTxt);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewC);
            this.Controls.Add(this.NameClientTxt);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneClientTxt);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.btn_remove_Client);
            this.Controls.Add(this.btn_add_Client);
            this.Controls.Add(this.btn_save_Client);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "clientform";
            this.Text = "clientform";
            this.Load += new System.EventHandler(this.clientform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox NationalIdClientTxt;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewC;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox NameClientTxt;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneClientTxt;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btn_remove_Client;
        private System.Windows.Forms.Button btn_add_Client;
        private System.Windows.Forms.Button btn_save_Client;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}