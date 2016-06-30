namespace tuantpps03715_assignment
{
    partial class sanpham
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
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtloaisp = new System.Windows.Forms.TextBox();
            this.btthemsp = new System.Windows.Forms.Button();
            this.btsuasp = new System.Windows.Forms.Button();
            this.btxoasp = new System.Windows.Forms.Button();
            this.btthoatsp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.gia,
            this.loaisp});
            this.dgvsanpham.Location = new System.Drawing.Point(12, 231);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.RowTemplate.Height = 24;
            this.dgvsanpham.Size = new System.Drawing.Size(1030, 271);
            this.dgvsanpham.TabIndex = 0;
            this.dgvsanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phảm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(135, 20);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(132, 22);
            this.txtmasp.TabIndex = 2;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(135, 72);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(132, 22);
            this.txttensp.TabIndex = 2;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(135, 125);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(132, 22);
            this.txtgia.TabIndex = 2;
            // 
            // txtloaisp
            // 
            this.txtloaisp.Location = new System.Drawing.Point(135, 174);
            this.txtloaisp.Name = "txtloaisp";
            this.txtloaisp.Size = new System.Drawing.Size(132, 22);
            this.txtloaisp.TabIndex = 2;
            // 
            // btthemsp
            // 
            this.btthemsp.Location = new System.Drawing.Point(379, 21);
            this.btthemsp.Name = "btthemsp";
            this.btthemsp.Size = new System.Drawing.Size(75, 23);
            this.btthemsp.TabIndex = 3;
            this.btthemsp.Text = "Thêm";
            this.btthemsp.UseVisualStyleBackColor = true;
            this.btthemsp.Click += new System.EventHandler(this.btthemsp_Click);
            // 
            // btsuasp
            // 
            this.btsuasp.Location = new System.Drawing.Point(379, 71);
            this.btsuasp.Name = "btsuasp";
            this.btsuasp.Size = new System.Drawing.Size(75, 23);
            this.btsuasp.TabIndex = 3;
            this.btsuasp.Text = "Sửa";
            this.btsuasp.UseVisualStyleBackColor = true;
            this.btsuasp.Click += new System.EventHandler(this.btsuasp_Click);
            // 
            // btxoasp
            // 
            this.btxoasp.Location = new System.Drawing.Point(379, 124);
            this.btxoasp.Name = "btxoasp";
            this.btxoasp.Size = new System.Drawing.Size(75, 23);
            this.btxoasp.TabIndex = 3;
            this.btxoasp.Text = "Xóa";
            this.btxoasp.UseVisualStyleBackColor = true;
            this.btxoasp.Click += new System.EventHandler(this.btxoasp_Click);
            // 
            // btthoatsp
            // 
            this.btthoatsp.Location = new System.Drawing.Point(379, 173);
            this.btthoatsp.Name = "btthoatsp";
            this.btthoatsp.Size = new System.Drawing.Size(75, 23);
            this.btthoatsp.TabIndex = 3;
            this.btthoatsp.Text = "Thoát";
            this.btthoatsp.UseVisualStyleBackColor = true;
            this.btthoatsp.Click += new System.EventHandler(this.btthoatsp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sản Phẩm";
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên Sản Phẩm";
            this.tensp.Name = "tensp";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // loaisp
            // 
            this.loaisp.DataPropertyName = "loaisp";
            this.loaisp.HeaderText = "Loại Sản Phẩm";
            this.loaisp.Name = "loaisp";
            // 
            // sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 514);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btthoatsp);
            this.Controls.Add(this.btxoasp);
            this.Controls.Add(this.btsuasp);
            this.Controls.Add(this.btthemsp);
            this.Controls.Add(this.txtloaisp);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvsanpham);
            this.Name = "sanpham";
            this.Text = "sanpham";
            this.Load += new System.EventHandler(this.sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtloaisp;
        private System.Windows.Forms.Button btthemsp;
        private System.Windows.Forms.Button btsuasp;
        private System.Windows.Forms.Button btxoasp;
        private System.Windows.Forms.Button btthoatsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
    }
}