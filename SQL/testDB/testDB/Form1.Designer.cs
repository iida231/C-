﻿
namespace testDB
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTableReadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReaderReadButton = new System.Windows.Forms.Button();
            this.ProductIdBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.InsertCommandButton = new System.Windows.Forms.Button();
            this.UpdateCommand = new System.Windows.Forms.Button();
            this.DeleteCommandButton = new System.Windows.Forms.Button();
            this.DapperReadButton = new System.Windows.Forms.Button();
            this.DapperInsertButton = new System.Windows.Forms.Button();
            this.EFreadButton = new System.Windows.Forms.Button();
            this.EFInsertButton = new System.Windows.Forms.Button();
            this.EFUpdateButton = new System.Windows.Forms.Button();
            this.EFDelete = new System.Windows.Forms.Button();
            this.create50000 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableReadButton
            // 
            this.DataTableReadButton.Location = new System.Drawing.Point(36, 31);
            this.DataTableReadButton.Name = "DataTableReadButton";
            this.DataTableReadButton.Size = new System.Drawing.Size(147, 26);
            this.DataTableReadButton.TabIndex = 0;
            this.DataTableReadButton.Text = "DataTableRead";
            this.DataTableReadButton.UseVisualStyleBackColor = true;
            this.DataTableReadButton.Click += new System.EventHandler(this.DataTableReadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(488, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(476, 308);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReaderReadButton
            // 
            this.ReaderReadButton.Location = new System.Drawing.Point(36, 98);
            this.ReaderReadButton.Name = "ReaderReadButton";
            this.ReaderReadButton.Size = new System.Drawing.Size(147, 26);
            this.ReaderReadButton.TabIndex = 2;
            this.ReaderReadButton.Text = "Reader　read";
            this.ReaderReadButton.UseVisualStyleBackColor = true;
            this.ReaderReadButton.Click += new System.EventHandler(this.ReaderReadButton_Click);
            // 
            // ProductIdBox
            // 
            this.ProductIdBox.Location = new System.Drawing.Point(288, 31);
            this.ProductIdBox.Name = "ProductIdBox";
            this.ProductIdBox.Size = new System.Drawing.Size(100, 25);
            this.ProductIdBox.TabIndex = 3;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(404, 31);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.ProductNameTextBox.TabIndex = 4;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(519, 31);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 25);
            this.PriceTextBox.TabIndex = 5;
            // 
            // InsertCommandButton
            // 
            this.InsertCommandButton.Location = new System.Drawing.Point(36, 148);
            this.InsertCommandButton.Name = "InsertCommandButton";
            this.InsertCommandButton.Size = new System.Drawing.Size(147, 26);
            this.InsertCommandButton.TabIndex = 6;
            this.InsertCommandButton.Text = "InsertCommand";
            this.InsertCommandButton.UseVisualStyleBackColor = true;
            this.InsertCommandButton.Click += new System.EventHandler(this.InsertCommandButton_Click);
            // 
            // UpdateCommand
            // 
            this.UpdateCommand.Location = new System.Drawing.Point(36, 198);
            this.UpdateCommand.Name = "UpdateCommand";
            this.UpdateCommand.Size = new System.Drawing.Size(147, 26);
            this.UpdateCommand.TabIndex = 7;
            this.UpdateCommand.Text = "UpdateCommand";
            this.UpdateCommand.UseVisualStyleBackColor = true;
            this.UpdateCommand.Click += new System.EventHandler(this.UpdateCommand_Click);
            // 
            // DeleteCommandButton
            // 
            this.DeleteCommandButton.Location = new System.Drawing.Point(36, 244);
            this.DeleteCommandButton.Name = "DeleteCommandButton";
            this.DeleteCommandButton.Size = new System.Drawing.Size(147, 26);
            this.DeleteCommandButton.TabIndex = 8;
            this.DeleteCommandButton.Text = "DeleteCommand";
            this.DeleteCommandButton.UseVisualStyleBackColor = true;
            this.DeleteCommandButton.Click += new System.EventHandler(this.DeleteCommandButton_Click);
            // 
            // DapperReadButton
            // 
            this.DapperReadButton.Location = new System.Drawing.Point(36, 300);
            this.DapperReadButton.Name = "DapperReadButton";
            this.DapperReadButton.Size = new System.Drawing.Size(147, 26);
            this.DapperReadButton.TabIndex = 9;
            this.DapperReadButton.Text = "DapperRead";
            this.DapperReadButton.UseVisualStyleBackColor = true;
            this.DapperReadButton.Click += new System.EventHandler(this.DapperReadButton_Click);
            // 
            // DapperInsertButton
            // 
            this.DapperInsertButton.Location = new System.Drawing.Point(36, 332);
            this.DapperInsertButton.Name = "DapperInsertButton";
            this.DapperInsertButton.Size = new System.Drawing.Size(147, 26);
            this.DapperInsertButton.TabIndex = 10;
            this.DapperInsertButton.Text = "DapperInsert";
            this.DapperInsertButton.UseVisualStyleBackColor = true;
            this.DapperInsertButton.Click += new System.EventHandler(this.DapperInsertButton_Click);
            // 
            // EFreadButton
            // 
            this.EFreadButton.Location = new System.Drawing.Point(210, 98);
            this.EFreadButton.Name = "EFreadButton";
            this.EFreadButton.Size = new System.Drawing.Size(147, 26);
            this.EFreadButton.TabIndex = 11;
            this.EFreadButton.Text = "EF read";
            this.EFreadButton.UseVisualStyleBackColor = true;
            this.EFreadButton.Click += new System.EventHandler(this.EFreadButton_Click);
            // 
            // EFInsertButton
            // 
            this.EFInsertButton.Location = new System.Drawing.Point(210, 148);
            this.EFInsertButton.Name = "EFInsertButton";
            this.EFInsertButton.Size = new System.Drawing.Size(147, 26);
            this.EFInsertButton.TabIndex = 12;
            this.EFInsertButton.Text = "EF insert";
            this.EFInsertButton.UseVisualStyleBackColor = true;
            this.EFInsertButton.Click += new System.EventHandler(this.EFInsertButton_Click);
            // 
            // EFUpdateButton
            // 
            this.EFUpdateButton.Location = new System.Drawing.Point(210, 198);
            this.EFUpdateButton.Name = "EFUpdateButton";
            this.EFUpdateButton.Size = new System.Drawing.Size(147, 26);
            this.EFUpdateButton.TabIndex = 13;
            this.EFUpdateButton.Text = "EFupdate";
            this.EFUpdateButton.UseVisualStyleBackColor = true;
            this.EFUpdateButton.Click += new System.EventHandler(this.EFUpdateButton_Click);
            // 
            // EFDelete
            // 
            this.EFDelete.Location = new System.Drawing.Point(210, 244);
            this.EFDelete.Name = "EFDelete";
            this.EFDelete.Size = new System.Drawing.Size(147, 26);
            this.EFDelete.TabIndex = 14;
            this.EFDelete.Text = "EFDelete";
            this.EFDelete.UseVisualStyleBackColor = true;
            this.EFDelete.Click += new System.EventHandler(this.EFDelete_Click);
            // 
            // create50000
            // 
            this.create50000.Location = new System.Drawing.Point(210, 300);
            this.create50000.Name = "create50000";
            this.create50000.Size = new System.Drawing.Size(147, 26);
            this.create50000.TabIndex = 15;
            this.create50000.Text = "create 50000";
            this.create50000.UseVisualStyleBackColor = true;
            this.create50000.Click += new System.EventHandler(this.create50000_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 575);
            this.Controls.Add(this.create50000);
            this.Controls.Add(this.EFDelete);
            this.Controls.Add(this.EFUpdateButton);
            this.Controls.Add(this.EFInsertButton);
            this.Controls.Add(this.EFreadButton);
            this.Controls.Add(this.DapperInsertButton);
            this.Controls.Add(this.DapperReadButton);
            this.Controls.Add(this.DeleteCommandButton);
            this.Controls.Add(this.UpdateCommand);
            this.Controls.Add(this.InsertCommandButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductIdBox);
            this.Controls.Add(this.ReaderReadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DataTableReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DataTableReadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReaderReadButton;
        private System.Windows.Forms.TextBox ProductIdBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button InsertCommandButton;
        private System.Windows.Forms.Button UpdateCommand;
        private System.Windows.Forms.Button DeleteCommandButton;
        private System.Windows.Forms.Button DapperReadButton;
        private System.Windows.Forms.Button DapperInsertButton;
        private System.Windows.Forms.Button EFreadButton;
        private System.Windows.Forms.Button EFInsertButton;
        private System.Windows.Forms.Button EFUpdateButton;
        private System.Windows.Forms.Button EFDelete;
        private System.Windows.Forms.Button create50000;
    }
}

