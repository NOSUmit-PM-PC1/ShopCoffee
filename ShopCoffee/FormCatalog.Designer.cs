﻿namespace ShopCoffee
{
    partial class FormCatalog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCatalog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.корзинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decrease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // listViewCatalog
            // 
            this.listViewCatalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCatalog.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewCatalog.HideSelection = false;
            this.listViewCatalog.Location = new System.Drawing.Point(0, 24);
            this.listViewCatalog.Name = "listViewCatalog";
            this.listViewCatalog.Size = new System.Drawing.Size(443, 426);
            this.listViewCatalog.TabIndex = 2;
            this.listViewCatalog.UseCompatibleStateImageBehavior = false;
            this.listViewCatalog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Продукт";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип продукта";
            this.columnHeader3.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuUsers,
            this.корзинаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuUsers
            // 
            this.toolStripMenuUsers.CheckOnClick = true;
            this.toolStripMenuUsers.Name = "toolStripMenuUsers";
            this.toolStripMenuUsers.Size = new System.Drawing.Size(134, 20);
            this.toolStripMenuUsers.Text = "Выбор пользователя";
            // 
            // корзинаToolStripMenuItem
            // 
            this.корзинаToolStripMenuItem.Name = "корзинаToolStripMenuItem";
            this.корзинаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.корзинаToolStripMenuItem.Text = "Корзина";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product,
            this.sum,
            this.add,
            this.amount,
            this.decrease});
            this.dataGridViewCart.Location = new System.Drawing.Point(547, 27);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(474, 150);
            this.dataGridViewCart.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 20;
            // 
            // Product
            // 
            this.Product.HeaderText = "Товар";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 150;
            // 
            // sum
            // 
            this.sum.HeaderText = "сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // add
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.DefaultCellStyle = dataGridViewCellStyle1;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add.HeaderText = "добавить";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Text = "+";
            this.add.Width = 25;
            // 
            // amount
            // 
            this.amount.HeaderText = "количество";
            this.amount.Name = "amount";
            this.amount.Width = 50;
            // 
            // decrease
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.decrease.DefaultCellStyle = dataGridViewCellStyle2;
            this.decrease.FillWeight = 20F;
            this.decrease.HeaderText = "убавить";
            this.decrease.Name = "decrease";
            this.decrease.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.decrease.Text = "-";
            this.decrease.Width = 25;
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 450);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.listViewCatalog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCatalog";
            this.Text = "СимонШОП - все для кофе";
            this.Load += new System.EventHandler(this.FormCatalog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewCatalog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUsers;
        private System.Windows.Forms.ToolStripMenuItem корзинаToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewButtonColumn decrease;
    }
}

