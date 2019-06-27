namespace OMHASSEN
{
    partial class representiveform
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
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_delete_reps = new System.Windows.Forms.Button();
            this.btn_add_reps = new System.Windows.Forms.Button();
            this.btn_save_reps = new System.Windows.Forms.Button();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComuationRepTxt = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.SaleTargetTxt = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.salaryRepTxt = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.phoneRepTxt = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.NameRepTxt = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.NationalIdRepTxt = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "هدف البيع";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "العنوان";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "العنوان";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "التلفون";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "الأسم";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "الرقم القومى";
            this.columnHeader1.Width = 80;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(313, 343);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(907, 279);
            this.listView1.TabIndex = 96;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "المرتب";
            // 
            // btn_delete_reps
            // 
            this.btn_delete_reps.BackColor = System.Drawing.Color.DarkRed;
            this.btn_delete_reps.FlatAppearance.BorderSize = 0;
            this.btn_delete_reps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_reps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete_reps.Location = new System.Drawing.Point(48, 561);
            this.btn_delete_reps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete_reps.Name = "btn_delete_reps";
            this.btn_delete_reps.Size = new System.Drawing.Size(154, 63);
            this.btn_delete_reps.TabIndex = 95;
            this.btn_delete_reps.Text = "حذف";
            this.btn_delete_reps.UseVisualStyleBackColor = false;
            this.btn_delete_reps.Click += new System.EventHandler(this.btn_delete_reps_Click);
            // 
            // btn_add_reps
            // 
            this.btn_add_reps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.btn_add_reps.FlatAppearance.BorderSize = 0;
            this.btn_add_reps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_reps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_reps.Location = new System.Drawing.Point(48, 420);
            this.btn_add_reps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add_reps.Name = "btn_add_reps";
            this.btn_add_reps.Size = new System.Drawing.Size(154, 63);
            this.btn_add_reps.TabIndex = 94;
            this.btn_add_reps.Text = "أضافة";
            this.btn_add_reps.UseVisualStyleBackColor = false;
            this.btn_add_reps.Click += new System.EventHandler(this.btn_add_reps_Click);
            // 
            // btn_save_reps
            // 
            this.btn_save_reps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.btn_save_reps.FlatAppearance.BorderSize = 0;
            this.btn_save_reps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_reps.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_reps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_reps.Location = new System.Drawing.Point(966, 632);
            this.btn_save_reps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save_reps.Name = "btn_save_reps";
            this.btn_save_reps.Size = new System.Drawing.Size(254, 55);
            this.btn_save_reps.TabIndex = 93;
            this.btn_save_reps.Text = "حفظ";
            this.btn_save_reps.UseVisualStyleBackColor = false;
            this.btn_save_reps.Click += new System.EventHandler(this.btn_save_reps_Click);
            // 
            // AddressText
            // 
            this.AddressText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(912, 252);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(169, 27);
            this.AddressText.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1164, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "العنوان";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComuationRepTxt
            // 
            this.ComuationRepTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComuationRepTxt.Location = new System.Drawing.Point(66, 161);
            this.ComuationRepTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComuationRepTxt.Name = "ComuationRepTxt";
            this.ComuationRepTxt.Size = new System.Drawing.Size(157, 27);
            this.ComuationRepTxt.TabIndex = 90;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(233, 167);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(44, 20);
            this.label44.TabIndex = 89;
            this.label44.Text = "العمولة";
            // 
            // SaleTargetTxt
            // 
            this.SaleTargetTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleTargetTxt.Location = new System.Drawing.Point(409, 169);
            this.SaleTargetTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaleTargetTxt.Name = "SaleTargetTxt";
            this.SaleTargetTxt.Size = new System.Drawing.Size(190, 27);
            this.SaleTargetTxt.TabIndex = 88;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(659, 174);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 20);
            this.label45.TabIndex = 87;
            this.label45.Text = "نسبة الربح";
            // 
            // salaryRepTxt
            // 
            this.salaryRepTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryRepTxt.Location = new System.Drawing.Point(912, 160);
            this.salaryRepTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salaryRepTxt.Name = "salaryRepTxt";
            this.salaryRepTxt.Size = new System.Drawing.Size(169, 27);
            this.salaryRepTxt.TabIndex = 86;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(1165, 163);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(44, 20);
            this.label46.TabIndex = 85;
            this.label46.Text = "المرتب";
            // 
            // phoneRepTxt
            // 
            this.phoneRepTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneRepTxt.Location = new System.Drawing.Point(66, 55);
            this.phoneRepTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneRepTxt.Name = "phoneRepTxt";
            this.phoneRepTxt.Size = new System.Drawing.Size(157, 27);
            this.phoneRepTxt.TabIndex = 84;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(234, 60);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(43, 20);
            this.label43.TabIndex = 83;
            this.label43.Text = "التلفون";
            // 
            // NameRepTxt
            // 
            this.NameRepTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRepTxt.Location = new System.Drawing.Point(409, 66);
            this.NameRepTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameRepTxt.Name = "NameRepTxt";
            this.NameRepTxt.Size = new System.Drawing.Size(190, 27);
            this.NameRepTxt.TabIndex = 82;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(675, 66);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(36, 20);
            this.label41.TabIndex = 81;
            this.label41.Text = "الأسم";
            // 
            // NationalIdRepTxt
            // 
            this.NationalIdRepTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalIdRepTxt.Location = new System.Drawing.Point(912, 52);
            this.NationalIdRepTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NationalIdRepTxt.Name = "NationalIdRepTxt";
            this.NationalIdRepTxt.Size = new System.Drawing.Size(169, 27);
            this.NationalIdRepTxt.TabIndex = 80;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(1139, 57);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(70, 20);
            this.label40.TabIndex = 79;
            this.label40.Text = "الرقم القومى";
            // 
            // representiveform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 749);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_delete_reps);
            this.Controls.Add(this.btn_add_reps);
            this.Controls.Add(this.btn_save_reps);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComuationRepTxt);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.SaleTargetTxt);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.salaryRepTxt);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.phoneRepTxt);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.NameRepTxt);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.NationalIdRepTxt);
            this.Controls.Add(this.label40);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "representiveform";
            this.Text = "representiveform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_delete_reps;
        private System.Windows.Forms.Button btn_add_reps;
        private System.Windows.Forms.Button btn_save_reps;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ComuationRepTxt;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox SaleTargetTxt;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox salaryRepTxt;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox phoneRepTxt;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox NameRepTxt;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox NationalIdRepTxt;
        private System.Windows.Forms.Label label40;
    }
}