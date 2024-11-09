﻿namespace BloodBankManagement.View
{
    partial class BloodStockView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodStockView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            panel1 = new Panel();
            btn_print = new Guna.UI2.WinForms.Guna2Button();
            txtgroup = new ComboBox();
            label14 = new Label();
            txtstock = new TextBox();
            label10 = new Label();
            splitContainer2 = new SplitContainer();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            txtsearch = new TextBox();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            NhomMau = new DataGridViewTextBoxColumn();
            SoLuongMau = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1794, 77);
            panel3.TabIndex = 43;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(850, 19);
            label3.Name = "label3";
            label3.Size = new Size(174, 39);
            label3.TabIndex = 12;
            label3.Text = "Dự trữ máu";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 77);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1794, 699);
            splitContainer1.SplitterDistance = 619;
            splitContainer1.TabIndex = 44;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 699);
            panel2.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_print);
            panel1.Controls.Add(txtgroup);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtstock);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(0, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 433);
            panel1.TabIndex = 46;
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.Transparent;
            btn_print.BorderColor = SystemColors.ButtonShadow;
            btn_print.BorderRadius = 15;
            btn_print.BorderThickness = 1;
            btn_print.CustomizableEdges = customizableEdges1;
            btn_print.DisabledState.BorderColor = Color.DarkGray;
            btn_print.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_print.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_print.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_print.FillColor = SystemColors.ButtonFace;
            btn_print.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_print.ForeColor = Color.Black;
            btn_print.Image = (Image)resources.GetObject("btn_print.Image");
            btn_print.Location = new Point(251, 214);
            btn_print.Name = "btn_print";
            btn_print.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_print.Size = new Size(110, 32);
            btn_print.TabIndex = 66;
            btn_print.Text = "In";
            btn_print.Click += btn_print_Click;
            // 
            // txtgroup
            // 
            txtgroup.Font = new Font("Calibri", 12F);
            txtgroup.FormattingEnabled = true;
            txtgroup.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            txtgroup.Location = new Point(251, 85);
            txtgroup.Name = "txtgroup";
            txtgroup.Size = new Size(236, 32);
            txtgroup.TabIndex = 16;
            txtgroup.SelectedIndexChanged += txtgroup_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 12F);
            label14.Location = new Point(96, 93);
            label14.Name = "label14";
            label14.Size = new Size(104, 24);
            label14.TabIndex = 10;
            label14.Text = "Nhóm Máu";
            // 
            // txtstock
            // 
            txtstock.Font = new Font("Calibri", 12F);
            txtstock.Location = new Point(251, 139);
            txtstock.Multiline = true;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(236, 32);
            txtstock.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(96, 147);
            label10.Name = "label10";
            label10.Size = new Size(130, 24);
            label10.TabIndex = 2;
            label10.Text = "Số Lượng Máu";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(guna2Button4);
            splitContainer2.Panel1.Controls.Add(txtsearch);
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(guna2Button5);
            splitContainer2.Panel2.Controls.Add(guna2DataGridView1);
            splitContainer2.Size = new Size(1171, 699);
            splitContainer2.SplitterDistance = 138;
            splitContainer2.TabIndex = 0;
            // 
            // guna2Button4
            // 
            guna2Button4.AutoRoundedCorners = true;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderColor = SystemColors.ButtonShadow;
            guna2Button4.BorderRadius = 15;
            guna2Button4.BorderThickness = 1;
            guna2Button4.CustomizableEdges = customizableEdges3;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = SystemColors.ButtonFace;
            guna2Button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
            guna2Button4.Location = new Point(1066, 79);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button4.Size = new Size(78, 32);
            guna2Button4.TabIndex = 51;
            guna2Button4.Click += guna2Button4_Click_1;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Calibri", 12F);
            txtsearch.Location = new Point(714, 79);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(337, 32);
            txtsearch.TabIndex = 50;
            // 
            // guna2Button5
            // 
            guna2Button5.AutoRoundedCorners = true;
            guna2Button5.BackColor = Color.Transparent;
            guna2Button5.BorderColor = SystemColors.ButtonShadow;
            guna2Button5.BorderRadius = 15;
            guna2Button5.BorderThickness = 1;
            guna2Button5.CustomizableEdges = customizableEdges5;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = SystemColors.ButtonFace;
            guna2Button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            guna2Button5.ForeColor = Color.Black;
            guna2Button5.Image = (Image)resources.GetObject("guna2Button5.Image");
            guna2Button5.Location = new Point(1066, 467);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button5.Size = new Size(78, 32);
            guna2Button5.TabIndex = 50;
            guna2Button5.Click += guna2Button5_Click_1;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.IndianRed;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { NhomMau, SoLuongMau });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView1.Location = new Point(3, 3);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 58;
            guna2DataGridView1.Size = new Size(1165, 424);
            guna2DataGridView1.TabIndex = 48;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.IndianRed;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.Coral;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = SystemColors.ActiveCaption;
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            guna2DataGridView1.SelectionChanged += comboBox1_SelectedIndexChanged;
            // 
            // NhomMau
            // 
            NhomMau.DataPropertyName = "NhomMau";
            NhomMau.FillWeight = 95.95111F;
            NhomMau.HeaderText = "Nhóm máu";
            NhomMau.MinimumWidth = 6;
            NhomMau.Name = "NhomMau";
            // 
            // SoLuongMau
            // 
            SoLuongMau.DataPropertyName = "SoLuongMau";
            SoLuongMau.FillWeight = 95.95111F;
            SoLuongMau.HeaderText = "Số Lượng Máu";
            SoLuongMau.MinimumWidth = 6;
            SoLuongMau.Name = "SoLuongMau";
            // 
            // BloodStockView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1794, 776);
            Controls.Add(splitContainer1);
            Controls.Add(panel3);
            Name = "BloodStockView";
            Text = "BloodStock";
            Load += BloodStockView_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn NhomMau;
        private DataGridViewTextBoxColumn SoLuongMau;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_print;
        private ComboBox txtgroup;
        private Label label14;
        private TextBox txtstock;
        private Label label10;
        private Panel panel2;
    }
}