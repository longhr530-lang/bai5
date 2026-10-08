namespace nguyenhailongb5
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
        // Controls
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TabControl tabControlLeft;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageShipping;
        private System.Windows.Forms.GroupBox groupBoxShipping;
        private System.Windows.Forms.ComboBox cmbShippingType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalQuantity;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalWeight;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalPrice;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.ErrorProvider errorProvider;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tabControlLeft = new System.Windows.Forms.TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageShipping = new System.Windows.Forms.TabPage();
            this.groupBoxShipping = new System.Windows.Forms.GroupBox();
            this.cmbShippingType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalQuantity = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalPrice = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabControlLeft.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.tabPageShipping.SuspendLayout();
            this.groupBoxShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tabControlLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewItems);
            this.splitContainerMain.Size = new System.Drawing.Size(1000, 600);
            this.splitContainerMain.SplitterDistance = 330;
            this.splitContainerMain.TabIndex = 0;
            // 
            // tabControlLeft
            // 
            this.tabControlLeft.Controls.Add(this.tabPageCustomer);
            this.tabControlLeft.Controls.Add(this.tabPageShipping);
            this.tabControlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLeft.Location = new System.Drawing.Point(0, 0);
            this.tabControlLeft.Name = "tabControlLeft";
            this.tabControlLeft.SelectedIndex = 0;
            this.tabControlLeft.Size = new System.Drawing.Size(330, 600);
            this.tabControlLeft.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.groupBoxCustomer);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 24);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(322, 572);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Khách hàng";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.txtAddress);
            this.groupBoxCustomer.Controls.Add(this.txtPhone);
            this.groupBoxCustomer.Controls.Add(this.txtCustomerName);
            this.groupBoxCustomer.Controls.Add(this.label3);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Controls.Add(this.label1);
            this.groupBoxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCustomer.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(316, 180);
            this.groupBoxCustomer.TabIndex = 0;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Thông tin khách hàng";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(100, 72);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 64);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(100, 46);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(100, 20);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 23);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // tabPageShipping
            // 
            this.tabPageShipping.Controls.Add(this.groupBoxShipping);
            this.tabPageShipping.Location = new System.Drawing.Point(4, 24);
            this.tabPageShipping.Name = "tabPageShipping";
            this.tabPageShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShipping.Size = new System.Drawing.Size(322, 572);
            this.tabPageShipping.TabIndex = 1;
            this.tabPageShipping.Text = "Loại vận chuyển";
            this.tabPageShipping.UseVisualStyleBackColor = true;
            // 
            // groupBoxShipping
            // 
            this.groupBoxShipping.Controls.Add(this.cmbShippingType);
            this.groupBoxShipping.Controls.Add(this.label4);
            this.groupBoxShipping.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxShipping.Location = new System.Drawing.Point(3, 3);
            this.groupBoxShipping.Name = "groupBoxShipping";
            this.groupBoxShipping.Size = new System.Drawing.Size(316, 100);
            this.groupBoxShipping.TabIndex = 0;
            this.groupBoxShipping.TabStop = false;
            this.groupBoxShipping.Text = "Chọn phương thức";
            // 
            // cmbShippingType
            // 
            this.cmbShippingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShippingType.FormattingEnabled = true;
            this.cmbShippingType.Items.AddRange(new object[] {
            "Giao hàng tận nơi",
            "Nhận tại kho",
            "Giao nhanh (Express)"});
            this.cmbShippingType.Location = new System.Drawing.Point(100, 20);
            this.cmbShippingType.Name = "cmbShippingType";
            this.cmbShippingType.Size = new System.Drawing.Size(200, 23);
            this.cmbShippingType.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại vận chuyển:";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = true;
            this.dataGridViewItems.AllowUserToDeleteRows = true;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colQuantity,
            this.colWeight,
            this.colUnitPrice,
            this.colTotal});
            this.dataGridViewItems.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.Height = 25;
            this.dataGridViewItems.Size = new System.Drawing.Size(660, 564);
            this.dataGridViewItems.TabIndex = 0;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Tên hàng";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 220;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.Name = "colQuantity";
            // 
            // colWeight
            // 
            this.colWeight.HeaderText = "Trọng lượng (kg)";
            this.colWeight.Name = "colWeight";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Đơn giá";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Thành tiền";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.DefaultCellStyle.Format = "N2";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblTotalQuantity,
            this.lblTotalWeight,
            this.lblTotalPrice});
            this.statusStrip.Location = new System.Drawing.Point(0, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 17);
            this.lblTime.Text = "Thời gian: --:--:--";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(120, 17);
            this.lblTotalQuantity.Text = "Tổng số lượng: 0";
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(140, 17);
            this.lblTotalWeight.Text = "Tổng trọng lượng: 0.00 kg";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(120, 17);
            this.lblTotalPrice.Text = "Tổng tiền: 0.00";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1000, 622);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form1";
            this.Text = "Bảng điều khiển Quản lý Đơn giao hàng";
            this.KeyPreview = true;
            // hookup events will be done in Form1.cs
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tabControlLeft.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.tabPageShipping.ResumeLayout(false);
            this.groupBoxShipping.ResumeLayout(false);
            this.groupBoxShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
