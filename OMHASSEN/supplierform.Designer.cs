namespace OMHASSEN
{
    partial class supplierform
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
            this.listViewSupplier = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSupTxt = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddressSupTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneSupTxt = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_remove_supllier = new System.Windows.Forms.Button();
            this.btn_add_supllier = new System.Windows.Forms.Button();
            this.btn_save_supllier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSupplier
            // 
            this.listViewSupplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSupplier.FullRowSelect = true;
            this.listViewSupplier.Location = new System.Drawing.Point(365, 321);
            this.listViewSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.listViewSupplier.MultiSelect = false;
            this.listViewSupplier.Name = "listViewSupplier";
            this.listViewSupplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewSupplier.RightToLeftLayout = true;
            this.listViewSupplier.Size = new System.Drawing.Size(933, 279);
            this.listViewSupplier.TabIndex = 94;
            this.listViewSupplier.UseCompatibleStateImageBehavior = false;
            this.listViewSupplier.View = System.Windows.Forms.View.Details;
            this.listViewSupplier.SelectedIndexChanged += new System.EventHandler(this.listViewSupplier_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "الأسم";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "رقم التلفون";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "العنوان";
            this.columnHeader4.Width = 200;
            // 
            // NameSupTxt
            // 
            this.NameSupTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSupTxt.Location = new System.Drawing.Point(781, 86);
            this.NameSupTxt.Margin = new System.Windows.Forms.Padding(5);
            this.NameSupTxt.Name = "NameSupTxt";
            this.NameSupTxt.Size = new System.Drawing.Size(361, 27);
            this.NameSupTxt.TabIndex = 90;
            this.NameSupTxt.TextChanged += new System.EventHandler(this.NameSupTxt_TextChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1285, 88);
            this.label41.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 22);
            this.label41.TabIndex = 89;
            this.label41.Text = "الأسم";
            this.label41.Click += new System.EventHandler(this.label41_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1081, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 88;
            this.label2.Text = "بيانات المورد";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.panel2.Location = new System.Drawing.Point(-58, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1473, 15);
            this.panel2.TabIndex = 87;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AddressSupTxt
            // 
            this.AddressSupTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressSupTxt.Location = new System.Drawing.Point(781, 174);
            this.AddressSupTxt.Margin = new System.Windows.Forms.Padding(5);
            this.AddressSupTxt.Name = "AddressSupTxt";
            this.AddressSupTxt.Size = new System.Drawing.Size(361, 27);
            this.AddressSupTxt.TabIndex = 98;
            this.AddressSupTxt.TextChanged += new System.EventHandler(this.AddressSupTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1275, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 97;
            this.label1.Text = "العنوان";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phoneSupTxt
            // 
            this.phoneSupTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSupTxt.Location = new System.Drawing.Point(135, 117);
            this.phoneSupTxt.Margin = new System.Windows.Forms.Padding(5);
            this.phoneSupTxt.Name = "phoneSupTxt";
            this.phoneSupTxt.Size = new System.Drawing.Size(294, 27);
            this.phoneSupTxt.TabIndex = 96;
            this.phoneSupTxt.TextChanged += new System.EventHandler(this.phoneSupTxt_TextChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(492, 128);
            this.label43.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(84, 22);
            this.label43.TabIndex = 95;
            this.label43.Text = "  رقم التلفون";
            this.label43.Click += new System.EventHandler(this.label43_Click);
            // 
            // btn_remove_supllier
            // 
            this.btn_remove_supllier.BackColor = System.Drawing.Color.DarkRed;
            this.btn_remove_supllier.FlatAppearance.BorderSize = 0;
            this.btn_remove_supllier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_supllier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove_supllier.Location = new System.Drawing.Point(75, 537);
            this.btn_remove_supllier.Margin = new System.Windows.Forms.Padding(5);
            this.btn_remove_supllier.Name = "btn_remove_supllier";
            this.btn_remove_supllier.Size = new System.Drawing.Size(238, 63);
            this.btn_remove_supllier.TabIndex = 93;
            this.btn_remove_supllier.Text = "حذف";
            this.btn_remove_supllier.UseVisualStyleBackColor = false;
            this.btn_remove_supllier.Click += new System.EventHandler(this.btn_remove_supllier_Click);
            // 
            // btn_add_supllier
            // 
            this.btn_add_supllier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.btn_add_supllier.FlatAppearance.BorderSize = 0;
            this.btn_add_supllier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_supllier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_supllier.Location = new System.Drawing.Point(75, 395);
            this.btn_add_supllier.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_supllier.Name = "btn_add_supllier";
            this.btn_add_supllier.Size = new System.Drawing.Size(238, 63);
            this.btn_add_supllier.TabIndex = 92;
            this.btn_add_supllier.Text = "أضافة";
            this.btn_add_supllier.UseVisualStyleBackColor = false;
            this.btn_add_supllier.Click += new System.EventHandler(this.btn_add_supllier_Click);
            // 
            // btn_save_supllier
            // 
            this.btn_save_supllier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.btn_save_supllier.FlatAppearance.BorderSize = 0;
            this.btn_save_supllier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_supllier.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_supllier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_supllier.Location = new System.Drawing.Point(1028, 636);
            this.btn_save_supllier.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save_supllier.Name = "btn_save_supllier";
            this.btn_save_supllier.Size = new System.Drawing.Size(270, 69);
            this.btn_save_supllier.TabIndex = 91;
            this.btn_save_supllier.Text = "حفظ";
            this.btn_save_supllier.UseVisualStyleBackColor = false;
            this.btn_save_supllier.Click += new System.EventHandler(this.btn_save_supllier_Click);
            // 
            // supplierform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.listViewSupplier);
            this.Controls.Add(this.NameSupTxt);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddressSupTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneSupTxt);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.btn_remove_supllier);
            this.Controls.Add(this.btn_add_supllier);
            this.Controls.Add(this.btn_save_supllier);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "supplierform";
            this.Text = "supplierform";
            this.Load += new System.EventHandler(this.supplierform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSupplier;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox NameSupTxt;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AddressSupTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneSupTxt;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btn_remove_supllier;
        private System.Windows.Forms.Button btn_add_supllier;
        private System.Windows.Forms.Button btn_save_supllier;
    }
}