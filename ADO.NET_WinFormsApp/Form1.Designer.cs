namespace ADO.NET_WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnDeliveries = new System.Windows.Forms.Button();
            this.btnMaxAmountGoods = new System.Windows.Forms.Button();
            this.btnMinAmountGoods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 12);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(776, 21);
            this.txtCommand.TabIndex = 0;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(12, 39);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(386, 23);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "Заполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(402, 39);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(386, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(12, 68);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 23;
            this.mainGrid.Size = new System.Drawing.Size(776, 370);
            this.mainGrid.TabIndex = 3;
            // 
            // btnGoods
            // 
            this.btnGoods.Location = new System.Drawing.Point(820, 39);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(75, 23);
            this.btnGoods.TabIndex = 4;
            this.btnGoods.Text = "Все товары";
            this.btnGoods.UseVisualStyleBackColor = true;
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.AutoSize = true;
            this.btnSuppliers.Location = new System.Drawing.Point(820, 68);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(99, 23);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "Поставщики";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.AutoSize = true;
            this.btnDeliveries.Location = new System.Drawing.Point(820, 97);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.Size = new System.Drawing.Size(99, 23);
            this.btnDeliveries.TabIndex = 6;
            this.btnDeliveries.Text = "Поставки";
            this.btnDeliveries.UseVisualStyleBackColor = true;
            this.btnDeliveries.Click += new System.EventHandler(this.btnDeliveries_Click);
            // 
            // btnMaxAmountGoods
            // 
            this.btnMaxAmountGoods.AutoSize = true;
            this.btnMaxAmountGoods.Location = new System.Drawing.Point(794, 126);
            this.btnMaxAmountGoods.Name = "btnMaxAmountGoods";
            this.btnMaxAmountGoods.Size = new System.Drawing.Size(202, 36);
            this.btnMaxAmountGoods.TabIndex = 7;
            this.btnMaxAmountGoods.Text = "Показать товар\r\n с максимальным количеством";
            this.btnMaxAmountGoods.UseVisualStyleBackColor = true;
            this.btnMaxAmountGoods.Click += new System.EventHandler(this.btnMaxAmountGoods_Click);
            // 
            // btnMinAmountGoods
            // 
            this.btnMinAmountGoods.AutoSize = true;
            this.btnMinAmountGoods.Location = new System.Drawing.Point(794, 168);
            this.btnMinAmountGoods.Name = "btnMinAmountGoods";
            this.btnMinAmountGoods.Size = new System.Drawing.Size(202, 36);
            this.btnMinAmountGoods.TabIndex = 8;
            this.btnMinAmountGoods.Text = "Показать товар\r\n с минимальным количеством";
            this.btnMinAmountGoods.UseVisualStyleBackColor = true;
            this.btnMinAmountGoods.Click += new System.EventHandler(this.btnMinAmountGoods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.btnMinAmountGoods);
            this.Controls.Add(this.btnMaxAmountGoods);
            this.Controls.Add(this.btnDeliveries);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.txtCommand);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCommand;
        private Button btnFill;
        private Button btnUpdate;
        private DataGridView mainGrid;
        private Button btnGoods;
        private Button btnSuppliers;
        private Button btnDeliveries;
        private Button btnMaxAmountGoods;
        private Button btnMinAmountGoods;
    }
}