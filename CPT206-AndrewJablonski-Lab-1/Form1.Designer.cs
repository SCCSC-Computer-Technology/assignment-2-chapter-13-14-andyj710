
namespace CPT206_AndrewJablonski_Lab_1
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
            this.components = new System.ComponentModel.Container();
            this.productNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchProductNumber = new System.Windows.Forms.Button();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.minAndMaxButton = new System.Windows.Forms.Button();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.unitDataGridView = new System.Windows.Forms.DataGridView();
            this.PriceDataGridView = new System.Windows.Forms.DataGridView();
            this.productDescTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minPriceTextBox = new System.Windows.Forms.TextBox();
            this.maxPriceTextBox = new System.Windows.Forms.TextBox();
            this.greaterThanButton = new System.Windows.Forms.Button();
            this.lessThanButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionDataGridView = new System.Windows.Forms.DataGridView();
            this.searchDescButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productNumberTextBox
            // 
            this.productNumberTextBox.Location = new System.Drawing.Point(313, 157);
            this.productNumberTextBox.Name = "productNumberTextBox";
            this.productNumberTextBox.Size = new System.Drawing.Size(173, 22);
            this.productNumberTextBox.TabIndex = 2;
            // 
            // searchProductNumber
            // 
            this.searchProductNumber.Location = new System.Drawing.Point(492, 156);
            this.searchProductNumber.Name = "searchProductNumber";
            this.searchProductNumber.Size = new System.Drawing.Size(107, 23);
            this.searchProductNumber.TabIndex = 3;
            this.searchProductNumber.Text = "Search";
            this.searchProductNumber.UseVisualStyleBackColor = true;
            this.searchProductNumber.Click += new System.EventHandler(this.searchProductNumber_Click);
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.Location = new System.Drawing.Point(131, 551);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(173, 22);
            this.unitsTextBox.TabIndex = 6;
            // 
            // minAndMaxButton
            // 
            this.minAndMaxButton.Location = new System.Drawing.Point(384, 799);
            this.minAndMaxButton.Name = "minAndMaxButton";
            this.minAndMaxButton.Size = new System.Drawing.Size(218, 23);
            this.minAndMaxButton.TabIndex = 9;
            this.minAndMaxButton.Text = "Search for Min and Max Price";
            this.minAndMaxButton.UseVisualStyleBackColor = true;
            this.minAndMaxButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.RowHeadersWidth = 51;
            this.ProductDataGridView.RowTemplate.Height = 24;
            this.ProductDataGridView.Size = new System.Drawing.Size(593, 138);
            this.ProductDataGridView.TabIndex = 10;
            // 
            // unitDataGridView
            // 
            this.unitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitDataGridView.Location = new System.Drawing.Point(9, 367);
            this.unitDataGridView.Name = "unitDataGridView";
            this.unitDataGridView.RowHeadersWidth = 51;
            this.unitDataGridView.RowTemplate.Height = 24;
            this.unitDataGridView.Size = new System.Drawing.Size(593, 175);
            this.unitDataGridView.TabIndex = 11;
            // 
            // PriceDataGridView
            // 
            this.PriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGridView.Location = new System.Drawing.Point(9, 586);
            this.PriceDataGridView.Name = "PriceDataGridView";
            this.PriceDataGridView.RowHeadersWidth = 51;
            this.PriceDataGridView.RowTemplate.Height = 24;
            this.PriceDataGridView.Size = new System.Drawing.Size(593, 206);
            this.PriceDataGridView.TabIndex = 12;
            // 
            // productDescTextBox
            // 
            this.productDescTextBox.Location = new System.Drawing.Point(313, 339);
            this.productDescTextBox.Name = "productDescTextBox";
            this.productDescTextBox.Size = new System.Drawing.Size(173, 22);
            this.productDescTextBox.TabIndex = 13;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Enabled = false;
            this.label.Location = new System.Drawing.Point(6, 160);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 17);
            this.label.TabIndex = 14;
            this.label.Text = "Number 4:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(13, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number 5:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(11, 801);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number 6:";
            // 
            // minPriceTextBox
            // 
            this.minPriceTextBox.Location = new System.Drawing.Point(131, 798);
            this.minPriceTextBox.Name = "minPriceTextBox";
            this.minPriceTextBox.Size = new System.Drawing.Size(90, 22);
            this.minPriceTextBox.TabIndex = 18;
            // 
            // maxPriceTextBox
            // 
            this.maxPriceTextBox.Location = new System.Drawing.Point(272, 798);
            this.maxPriceTextBox.Name = "maxPriceTextBox";
            this.maxPriceTextBox.Size = new System.Drawing.Size(90, 22);
            this.maxPriceTextBox.TabIndex = 19;
            // 
            // greaterThanButton
            // 
            this.greaterThanButton.Location = new System.Drawing.Point(320, 549);
            this.greaterThanButton.Name = "greaterThanButton";
            this.greaterThanButton.Size = new System.Drawing.Size(126, 27);
            this.greaterThanButton.TabIndex = 20;
            this.greaterThanButton.Text = "Greater than";
            this.greaterThanButton.UseVisualStyleBackColor = true;
            this.greaterThanButton.Click += new System.EventHandler(this.greaterThanButton_Click);
            // 
            // lessThanButton
            // 
            this.lessThanButton.Location = new System.Drawing.Point(470, 548);
            this.lessThanButton.Name = "lessThanButton";
            this.lessThanButton.Size = new System.Drawing.Size(126, 28);
            this.lessThanButton.TabIndex = 21;
            this.lessThanButton.Text = "Less than";
            this.lessThanButton.UseVisualStyleBackColor = true;
            this.lessThanButton.Click += new System.EventHandler(this.lessThanButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(91, 798);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(229, 799);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(6, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Number 4:";
            // 
            // descriptionDataGridView
            // 
            this.descriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descriptionDataGridView.Location = new System.Drawing.Point(9, 185);
            this.descriptionDataGridView.Name = "descriptionDataGridView";
            this.descriptionDataGridView.RowHeadersWidth = 51;
            this.descriptionDataGridView.RowTemplate.Height = 24;
            this.descriptionDataGridView.Size = new System.Drawing.Size(593, 138);
            this.descriptionDataGridView.TabIndex = 25;
            // 
            // searchDescButton
            // 
            this.searchDescButton.Location = new System.Drawing.Point(495, 338);
            this.searchDescButton.Name = "searchDescButton";
            this.searchDescButton.Size = new System.Drawing.Size(107, 23);
            this.searchDescButton.TabIndex = 26;
            this.searchDescButton.Text = "Search";
            this.searchDescButton.UseVisualStyleBackColor = true;
            this.searchDescButton.Click += new System.EventHandler(this.searchDescButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(106, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Search for product number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(94, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Search For product description:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 835);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchDescButton);
            this.Controls.Add(this.descriptionDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lessThanButton);
            this.Controls.Add(this.greaterThanButton);
            this.Controls.Add(this.maxPriceTextBox);
            this.Controls.Add(this.minPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.productDescTextBox);
            this.Controls.Add(this.PriceDataGridView);
            this.Controls.Add(this.unitDataGridView);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.minAndMaxButton);
            this.Controls.Add(this.unitsTextBox);
            this.Controls.Add(this.searchProductNumber);
            this.Controls.Add(this.productNumberTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AndyJablonski-CPT206-Lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox productNumberTextBox;
        private System.Windows.Forms.Button searchProductNumber;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.Button minAndMaxButton;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.DataGridView unitDataGridView;
        private System.Windows.Forms.DataGridView PriceDataGridView;
        private System.Windows.Forms.TextBox productDescTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minPriceTextBox;
        private System.Windows.Forms.TextBox maxPriceTextBox;
        private System.Windows.Forms.Button greaterThanButton;
        private System.Windows.Forms.Button lessThanButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView descriptionDataGridView;
        private System.Windows.Forms.Button searchDescButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

