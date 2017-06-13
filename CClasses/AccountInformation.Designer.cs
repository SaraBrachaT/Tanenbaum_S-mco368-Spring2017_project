using System;

namespace CClasses
{
    partial class AccountInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monetaryOptions = new System.Windows.Forms.TabControl();
            this.viewAcctTab = new System.Windows.Forms.TabPage();
            this.acctBalanceLbl = new System.Windows.Forms.Label();
            this.payTab = new System.Windows.Forms.TabPage();
            this.payBtn = new System.Windows.Forms.Button();
            this.paymentAmountTxt = new System.Windows.Forms.TextBox();
            this.amntPayLbl = new System.Windows.Forms.Label();
            this.viewPurchases = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.allPurchasesGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateGoBtn = new System.Windows.Forms.Button();
            this.datePurchasesGrid = new System.Windows.Forms.DataGridView();
            this.endDateDTP = new System.Windows.Forms.DateTimePicker();
            this.startDateDTP = new System.Windows.Forms.DateTimePicker();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.priceGoBtn = new System.Windows.Forms.Button();
            this.pricePurchasesGrid = new System.Windows.Forms.DataGridView();
            this.maxPriceTxt = new System.Windows.Forms.TextBox();
            this.minPriceTxt = new System.Windows.Forms.TextBox();
            this.maxPriceLbl = new System.Windows.Forms.Label();
            this.minPriceLbl = new System.Windows.Forms.Label();
            this.userAccountLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.toItemListingBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.monetaryOptions.SuspendLayout();
            this.viewAcctTab.SuspendLayout();
            this.payTab.SuspendLayout();
            this.viewPurchases.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPurchasesGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasesGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePurchasesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monetaryOptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.viewPurchases);
            this.splitContainer1.Size = new System.Drawing.Size(1131, 487);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // monetaryOptions
            // 
            this.monetaryOptions.Controls.Add(this.viewAcctTab);
            this.monetaryOptions.Controls.Add(this.payTab);
            this.monetaryOptions.Location = new System.Drawing.Point(4, 4);
            this.monetaryOptions.Margin = new System.Windows.Forms.Padding(4);
            this.monetaryOptions.Name = "monetaryOptions";
            this.monetaryOptions.SelectedIndex = 0;
            this.monetaryOptions.Size = new System.Drawing.Size(1122, 155);
            this.monetaryOptions.TabIndex = 0;
            this.monetaryOptions.SelectedIndexChanged += new System.EventHandler(this.switchtab_Click);
            // 
            // viewAcctTab
            // 
            this.viewAcctTab.Controls.Add(this.acctBalanceLbl);
            this.viewAcctTab.Location = new System.Drawing.Point(4, 28);
            this.viewAcctTab.Margin = new System.Windows.Forms.Padding(4);
            this.viewAcctTab.Name = "viewAcctTab";
            this.viewAcctTab.Padding = new System.Windows.Forms.Padding(4);
            this.viewAcctTab.Size = new System.Drawing.Size(1114, 123);
            this.viewAcctTab.TabIndex = 0;
            this.viewAcctTab.Text = "View Account Balance";
            this.viewAcctTab.UseVisualStyleBackColor = true;
            // 
            // acctBalanceLbl
            // 
            this.acctBalanceLbl.AutoSize = true;
            this.acctBalanceLbl.Font = new System.Drawing.Font("Narkisim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctBalanceLbl.Location = new System.Drawing.Point(369, 44);
            this.acctBalanceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acctBalanceLbl.Name = "acctBalanceLbl";
            this.acctBalanceLbl.Size = new System.Drawing.Size(0, 24);
            this.acctBalanceLbl.TabIndex = 0;
            this.acctBalanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payTab
            // 
            this.payTab.Controls.Add(this.payBtn);
            this.payTab.Controls.Add(this.paymentAmountTxt);
            this.payTab.Controls.Add(this.amntPayLbl);
            this.payTab.Location = new System.Drawing.Point(4, 28);
            this.payTab.Margin = new System.Windows.Forms.Padding(4);
            this.payTab.Name = "payTab";
            this.payTab.Padding = new System.Windows.Forms.Padding(4);
            this.payTab.Size = new System.Drawing.Size(1114, 123);
            this.payTab.TabIndex = 1;
            this.payTab.Text = "Pay Account Balance";
            this.payTab.UseVisualStyleBackColor = true;
            // 
            // payBtn
            // 
            this.payBtn.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.Location = new System.Drawing.Point(738, 54);
            this.payBtn.Margin = new System.Windows.Forms.Padding(4);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(250, 32);
            this.payBtn.TabIndex = 2;
            this.payBtn.Text = "Submit Payment";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // paymentAmountTxt
            // 
            this.paymentAmountTxt.Location = new System.Drawing.Point(563, 59);
            this.paymentAmountTxt.Margin = new System.Windows.Forms.Padding(4);
            this.paymentAmountTxt.Name = "paymentAmountTxt";
            this.paymentAmountTxt.Size = new System.Drawing.Size(148, 27);
            this.paymentAmountTxt.TabIndex = 1;
            // 
            // amntPayLbl
            // 
            this.amntPayLbl.AutoSize = true;
            this.amntPayLbl.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amntPayLbl.Location = new System.Drawing.Point(177, 60);
            this.amntPayLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amntPayLbl.Name = "amntPayLbl";
            this.amntPayLbl.Size = new System.Drawing.Size(389, 26);
            this.amntPayLbl.TabIndex = 0;
            this.amntPayLbl.Text = "Enter the amount you would like to pay        $";
            // 
            // viewPurchases
            // 
            this.viewPurchases.Controls.Add(this.tabPage1);
            this.viewPurchases.Controls.Add(this.tabPage2);
            this.viewPurchases.Controls.Add(this.tabPage3);
            this.viewPurchases.Location = new System.Drawing.Point(4, 4);
            this.viewPurchases.Margin = new System.Windows.Forms.Padding(4);
            this.viewPurchases.Name = "viewPurchases";
            this.viewPurchases.SelectedIndex = 0;
            this.viewPurchases.Size = new System.Drawing.Size(1126, 303);
            this.viewPurchases.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.allPurchasesGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1118, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All Purchases";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // allPurchasesGrid
            // 
            this.allPurchasesGrid.AllowUserToAddRows = false;
            this.allPurchasesGrid.AllowUserToDeleteRows = false;
            this.allPurchasesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allPurchasesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allPurchasesGrid.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.allPurchasesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.allPurchasesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPurchasesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allPurchasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPurchasesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.allPurchasesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allPurchasesGrid.GridColor = System.Drawing.Color.White;
            this.allPurchasesGrid.Location = new System.Drawing.Point(4, 4);
            this.allPurchasesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.allPurchasesGrid.Name = "allPurchasesGrid";
            this.allPurchasesGrid.ReadOnly = true;
            this.allPurchasesGrid.RowHeadersVisible = false;
            this.allPurchasesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.allPurchasesGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.allPurchasesGrid.RowTemplate.DividerHeight = 1;
            this.allPurchasesGrid.ShowEditingIcon = false;
            this.allPurchasesGrid.Size = new System.Drawing.Size(1110, 263);
            this.allPurchasesGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateGoBtn);
            this.tabPage2.Controls.Add(this.datePurchasesGrid);
            this.tabPage2.Controls.Add(this.endDateDTP);
            this.tabPage2.Controls.Add(this.startDateDTP);
            this.tabPage2.Controls.Add(this.endDateLbl);
            this.tabPage2.Controls.Add(this.startDateLbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1118, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Purchases Filtered By Date";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateGoBtn
            // 
            this.dateGoBtn.Location = new System.Drawing.Point(463, 33);
            this.dateGoBtn.Name = "dateGoBtn";
            this.dateGoBtn.Size = new System.Drawing.Size(75, 23);
            this.dateGoBtn.TabIndex = 5;
            this.dateGoBtn.Text = "Go";
            this.dateGoBtn.UseVisualStyleBackColor = true;
            this.dateGoBtn.Click += new System.EventHandler(this.dateGoBtn_Click);
            // 
            // datePurchasesGrid
            // 
            this.datePurchasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datePurchasesGrid.Location = new System.Drawing.Point(0, 87);
            this.datePurchasesGrid.Name = "datePurchasesGrid";
            this.datePurchasesGrid.Size = new System.Drawing.Size(1123, 251);
            this.datePurchasesGrid.TabIndex = 4;
            // 
            // endDateDTP
            // 
            this.endDateDTP.CalendarForeColor = System.Drawing.Color.DeepPink;
            this.endDateDTP.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.endDateDTP.CalendarTitleBackColor = System.Drawing.Color.PowderBlue;
            this.endDateDTP.CalendarTitleForeColor = System.Drawing.Color.DeepPink;
            this.endDateDTP.CalendarTrailingForeColor = System.Drawing.Color.PowderBlue;
            this.endDateDTP.Location = new System.Drawing.Point(223, 30);
            this.endDateDTP.Name = "endDateDTP";
            this.endDateDTP.Size = new System.Drawing.Size(200, 27);
            this.endDateDTP.TabIndex = 3;
            // 
            // startDateDTP
            // 
            this.startDateDTP.CalendarForeColor = System.Drawing.Color.DeepPink;
            this.startDateDTP.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.startDateDTP.CalendarTitleBackColor = System.Drawing.Color.PowderBlue;
            this.startDateDTP.CalendarTitleForeColor = System.Drawing.Color.DeepPink;
            this.startDateDTP.CalendarTrailingForeColor = System.Drawing.Color.PowderBlue;
            this.startDateDTP.Location = new System.Drawing.Point(8, 31);
            this.startDateDTP.Name = "startDateDTP";
            this.startDateDTP.Size = new System.Drawing.Size(200, 27);
            this.startDateDTP.TabIndex = 2;
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(235, 4);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(116, 19);
            this.endDateLbl.TabIndex = 1;
            this.endDateLbl.Text = "Select End Date";
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(8, 8);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(124, 19);
            this.startDateLbl.TabIndex = 0;
            this.startDateLbl.Text = "Select Start Date";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.priceGoBtn);
            this.tabPage3.Controls.Add(this.pricePurchasesGrid);
            this.tabPage3.Controls.Add(this.maxPriceTxt);
            this.tabPage3.Controls.Add(this.minPriceTxt);
            this.tabPage3.Controls.Add(this.maxPriceLbl);
            this.tabPage3.Controls.Add(this.minPriceLbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1118, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Purchases Filtered By Price";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // priceGoBtn
            // 
            this.priceGoBtn.Location = new System.Drawing.Point(719, 15);
            this.priceGoBtn.Name = "priceGoBtn";
            this.priceGoBtn.Size = new System.Drawing.Size(75, 23);
            this.priceGoBtn.TabIndex = 5;
            this.priceGoBtn.Text = "Go";
            this.priceGoBtn.UseVisualStyleBackColor = true;
            this.priceGoBtn.Click += new System.EventHandler(this.priceGoBtn_Click);
            // 
            // pricePurchasesGrid
            // 
            this.pricePurchasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricePurchasesGrid.Location = new System.Drawing.Point(0, 58);
            this.pricePurchasesGrid.Name = "pricePurchasesGrid";
            this.pricePurchasesGrid.Size = new System.Drawing.Size(1115, 213);
            this.pricePurchasesGrid.TabIndex = 4;
            // 
            // maxPriceTxt
            // 
            this.maxPriceTxt.Location = new System.Drawing.Point(566, 11);
            this.maxPriceTxt.Name = "maxPriceTxt";
            this.maxPriceTxt.Size = new System.Drawing.Size(100, 27);
            this.maxPriceTxt.TabIndex = 3;
            // 
            // minPriceTxt
            // 
            this.minPriceTxt.Location = new System.Drawing.Point(219, 17);
            this.minPriceTxt.Name = "minPriceTxt";
            this.minPriceTxt.Size = new System.Drawing.Size(100, 27);
            this.minPriceTxt.TabIndex = 2;
            // 
            // maxPriceLbl
            // 
            this.maxPriceLbl.AutoSize = true;
            this.maxPriceLbl.Location = new System.Drawing.Point(369, 19);
            this.maxPriceLbl.Name = "maxPriceLbl";
            this.maxPriceLbl.Size = new System.Drawing.Size(191, 19);
            this.maxPriceLbl.TabIndex = 1;
            this.maxPriceLbl.Text = "Enter the maximum price: $";
            // 
            // minPriceLbl
            // 
            this.minPriceLbl.AutoSize = true;
            this.minPriceLbl.Location = new System.Drawing.Point(24, 19);
            this.minPriceLbl.Name = "minPriceLbl";
            this.minPriceLbl.Size = new System.Drawing.Size(188, 19);
            this.minPriceLbl.TabIndex = 0;
            this.minPriceLbl.Text = "Enter the minimum price: $";
            // 
            // userAccountLbl
            // 
            this.userAccountLbl.Font = new System.Drawing.Font("Narkisim", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAccountLbl.Location = new System.Drawing.Point(39, 26);
            this.userAccountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userAccountLbl.Name = "userAccountLbl";
            this.userAccountLbl.Size = new System.Drawing.Size(910, 34);
            this.userAccountLbl.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = global::CClasses.Properties.Resources.Exit;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.exitBtn.FlatAppearance.BorderSize = 10;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Location = new System.Drawing.Point(1048, 548);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(80, 100);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // toItemListingBtn
            // 
            this.toItemListingBtn.BackgroundImage = global::CClasses.Properties.Resources.Shopping_Bag;
            this.toItemListingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toItemListingBtn.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toItemListingBtn.Location = new System.Drawing.Point(1024, 1);
            this.toItemListingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.toItemListingBtn.Name = "toItemListingBtn";
            this.toItemListingBtn.Size = new System.Drawing.Size(103, 82);
            this.toItemListingBtn.TabIndex = 1;
            this.toItemListingBtn.Text = "Back\r\nto\r\nShop";
            this.toItemListingBtn.UseVisualStyleBackColor = true;
            this.toItemListingBtn.Click += new System.EventHandler(this.toItemListingBtn_Click);
            // 
            // AccountInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1131, 637);
            this.Controls.Add(this.toItemListingBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.userAccountLbl);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountInformation";
            this.Load += new System.EventHandler(this.AccountInformation_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.monetaryOptions.ResumeLayout(false);
            this.viewAcctTab.ResumeLayout(false);
            this.viewAcctTab.PerformLayout();
            this.payTab.ResumeLayout(false);
            this.payTab.PerformLayout();
            this.viewPurchases.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allPurchasesGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasesGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePurchasesGrid)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl monetaryOptions;
        private System.Windows.Forms.TabPage viewAcctTab;
        private System.Windows.Forms.TabPage payTab;
        private System.Windows.Forms.Label acctBalanceLbl;
        private System.Windows.Forms.Button toItemListingBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label userAccountLbl;
        private System.Windows.Forms.TextBox paymentAmountTxt;
        private System.Windows.Forms.Label amntPayLbl;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.TabControl viewPurchases;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView allPurchasesGrid;
        private System.Windows.Forms.DateTimePicker endDateDTP;
        private System.Windows.Forms.DateTimePicker startDateDTP;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.DataGridView datePurchasesGrid;
        private System.Windows.Forms.DataGridView pricePurchasesGrid;
        private System.Windows.Forms.TextBox maxPriceTxt;
        private System.Windows.Forms.TextBox minPriceTxt;
        private System.Windows.Forms.Label maxPriceLbl;
        private System.Windows.Forms.Label minPriceLbl;
        private System.Windows.Forms.Button dateGoBtn;
        private System.Windows.Forms.Button priceGoBtn;
    }
}