﻿namespace Client
{
    partial class Orders
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
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.btnApproveSelected = new System.Windows.Forms.Button();
            this.btnApproveAll = new System.Windows.Forms.Button();
            this.btnApproved = new System.Windows.Forms.Button();
            this.gvSelectedOrder = new System.Windows.Forms.DataGridView();
            this.getOrdersListCompletedEventArgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getOrdersListCompletedEventArgsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblAllOrders = new System.Windows.Forms.Label();
            this.lblSelectedORder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrdersListCompletedEventArgsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrdersListCompletedEventArgsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(1253, 22);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(39, 17);
            this.lnkBack.TabIndex = 3;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // dgOrders
            // 
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(12, 59);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.RowTemplate.Height = 24;
            this.dgOrders.Size = new System.Drawing.Size(737, 398);
            this.dgOrders.TabIndex = 2;
            this.dgOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellContentClick);
            // 
            // btnApproveSelected
            // 
            this.btnApproveSelected.Location = new System.Drawing.Point(501, 465);
            this.btnApproveSelected.Name = "btnApproveSelected";
            this.btnApproveSelected.Size = new System.Drawing.Size(134, 25);
            this.btnApproveSelected.TabIndex = 4;
            this.btnApproveSelected.Text = "Approve Selected";
            this.btnApproveSelected.UseVisualStyleBackColor = true;
            // 
            // btnApproveAll
            // 
            this.btnApproveAll.Location = new System.Drawing.Point(665, 463);
            this.btnApproveAll.Name = "btnApproveAll";
            this.btnApproveAll.Size = new System.Drawing.Size(107, 27);
            this.btnApproveAll.TabIndex = 5;
            this.btnApproveAll.Text = "Approve All";
            this.btnApproveAll.UseVisualStyleBackColor = true;
            this.btnApproveAll.Click += new System.EventHandler(this.btnApproveAll_Click);
            // 
            // btnApproved
            // 
            this.btnApproved.Location = new System.Drawing.Point(619, 496);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(153, 34);
            this.btnApproved.TabIndex = 6;
            this.btnApproved.Text = "Approved Orders";
            this.btnApproved.UseVisualStyleBackColor = true;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // gvSelectedOrder
            // 
            this.gvSelectedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSelectedOrder.Location = new System.Drawing.Point(755, 59);
            this.gvSelectedOrder.Name = "gvSelectedOrder";
            this.gvSelectedOrder.RowTemplate.Height = 24;
            this.gvSelectedOrder.Size = new System.Drawing.Size(549, 140);
            this.gvSelectedOrder.TabIndex = 7;
            this.gvSelectedOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // getOrdersListCompletedEventArgsBindingSource
            // 
            this.getOrdersListCompletedEventArgsBindingSource.DataSource = typeof(Client.localhost.GetOrdersListCompletedEventArgs);
            // 
            // getOrdersListCompletedEventArgsBindingSource1
            // 
            this.getOrdersListCompletedEventArgsBindingSource1.DataSource = typeof(Client.localhost.GetOrdersListCompletedEventArgs);
            // 
            // lblAllOrders
            // 
            this.lblAllOrders.AutoSize = true;
            this.lblAllOrders.Location = new System.Drawing.Point(12, 39);
            this.lblAllOrders.Name = "lblAllOrders";
            this.lblAllOrders.Size = new System.Drawing.Size(71, 17);
            this.lblAllOrders.TabIndex = 8;
            this.lblAllOrders.Text = "All Orders";
            // 
            // lblSelectedORder
            // 
            this.lblSelectedORder.AutoSize = true;
            this.lblSelectedORder.Location = new System.Drawing.Point(884, 39);
            this.lblSelectedORder.Name = "lblSelectedORder";
            this.lblSelectedORder.Size = new System.Drawing.Size(104, 17);
            this.lblSelectedORder.TabIndex = 9;
            this.lblSelectedORder.Text = "Selected Order";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 542);
            this.Controls.Add(this.lblSelectedORder);
            this.Controls.Add(this.lblAllOrders);
            this.Controls.Add(this.gvSelectedOrder);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.btnApproveAll);
            this.Controls.Add(this.btnApproveSelected);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.dgOrders);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrdersListCompletedEventArgsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrdersListCompletedEventArgsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Button btnApproveSelected;
        private System.Windows.Forms.Button btnApproveAll;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.DataGridView gvSelectedOrder;
        private System.Windows.Forms.BindingSource getOrdersListCompletedEventArgsBindingSource;
        private System.Windows.Forms.BindingSource getOrdersListCompletedEventArgsBindingSource1;
        private System.Windows.Forms.Label lblAllOrders;
        private System.Windows.Forms.Label lblSelectedORder;
    }
}