namespace OMHASSEN
{
    partial class products
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
            this.button16 = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.Label();
            this.AmountNumberList = new System.Windows.Forms.DomainUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.WholePriceTxt = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.MeasuringUnitTxt = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.RetailPriceTxt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeasuringUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WholeSalePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RetailPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.button16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(64, 285);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(302, 78);
            this.button16.TabIndex = 40;
            this.button16.Text = "حفظ";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(278, 183);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(161, 27);
            this.Amount.TabIndex = 93;
            this.Amount.Text = "الكمية المراد إضافتها";
            this.Amount.Visible = false;
            // 
            // AmountNumberList
            // 
            this.AmountNumberList.Location = new System.Drawing.Point(94, 176);
            this.AmountNumberList.Name = "AmountNumberList";
            this.AmountNumberList.Size = new System.Drawing.Size(120, 34);
            this.AmountNumberList.TabIndex = 94;
            this.AmountNumberList.Text = "0";
            this.AmountNumberList.Visible = false;
            this.AmountNumberList.SelectedItemChanged += new System.EventHandler(this.AmountNumberList_SelectedItemChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1497, 15);
            this.panel2.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1265, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "المنتجات";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(953, 118);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(328, 27);
            this.CategoryComboBox.TabIndex = 29;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTxt.Location = new System.Drawing.Point(953, 183);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(329, 27);
            this.ProductNameTxt.TabIndex = 30;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(1291, 120);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 19);
            this.label31.TabIndex = 31;
            this.label31.Text = "نوع الصنف";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(1293, 189);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(70, 19);
            this.label32.TabIndex = 32;
            this.label32.Text = "أسم المنتج";
            // 
            // WholePriceTxt
            // 
            this.WholePriceTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WholePriceTxt.Location = new System.Drawing.Point(484, 181);
            this.WholePriceTxt.Name = "WholePriceTxt";
            this.WholePriceTxt.Size = new System.Drawing.Size(327, 27);
            this.WholePriceTxt.TabIndex = 33;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(819, 185);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(75, 19);
            this.label33.TabIndex = 34;
            this.label33.Text = "سعر الجملة";
            // 
            // MeasuringUnitTxt
            // 
            this.MeasuringUnitTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasuringUnitTxt.Location = new System.Drawing.Point(483, 119);
            this.MeasuringUnitTxt.Name = "MeasuringUnitTxt";
            this.MeasuringUnitTxt.Size = new System.Drawing.Size(327, 27);
            this.MeasuringUnitTxt.TabIndex = 35;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(819, 123);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 19);
            this.label35.TabIndex = 36;
            this.label35.Text = "وحدة القياس";
            // 
            // RetailPriceTxt
            // 
            this.RetailPriceTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetailPriceTxt.Location = new System.Drawing.Point(64, 129);
            this.RetailPriceTxt.Name = "RetailPriceTxt";
            this.RetailPriceTxt.Size = new System.Drawing.Size(276, 27);
            this.RetailPriceTxt.TabIndex = 37;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(349, 133);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(81, 19);
            this.label34.TabIndex = 38;
            this.label34.Text = "سعر القطاعى";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(93)))));
            this.button15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(879, 285);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(302, 78);
            this.button15.TabIndex = 39;
            this.button15.Text = "أضافة";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DarkRed;
            this.button17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(483, 285);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(302, 78);
            this.button17.TabIndex = 41;
            this.button17.Text = "حذف";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.category,
            this.AmountCol,
            this.MeasuringUnit,
            this.WholeSalePrice,
            this.RetailPrice});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(443, 435);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(729, 208);
            this.listView1.TabIndex = 95;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ProductName
            // 
            this.ProductName.Text = "اسم المنتج";
            this.ProductName.Width = 124;
            // 
            // category
            // 
            this.category.Text = "الصنف";
            this.category.Width = 82;
            // 
            // AmountCol
            // 
            this.AmountCol.Text = "الكمية";
            this.AmountCol.Width = 111;
            // 
            // MeasuringUnit
            // 
            this.MeasuringUnit.Text = "وحدة القياس";
            this.MeasuringUnit.Width = 109;
            // 
            // WholeSalePrice
            // 
            this.WholeSalePrice.Text = "سعر الجملة";
            this.WholeSalePrice.Width = 128;
            // 
            // RetailPrice
            // 
            this.RetailPrice.Text = "سعر القطاعي";
            this.RetailPrice.Width = 98;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 725);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AmountNumberList);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.RetailPriceTxt);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.MeasuringUnitTxt);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.WholePriceTxt);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.CategoryComboBox);
            this.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "products";
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.DomainUpDown AmountNumberList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox WholePriceTxt;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox MeasuringUnitTxt;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox RetailPriceTxt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader AmountCol;
        private System.Windows.Forms.ColumnHeader MeasuringUnit;
        private System.Windows.Forms.ColumnHeader WholeSalePrice;
        private System.Windows.Forms.ColumnHeader RetailPrice;
    }
}