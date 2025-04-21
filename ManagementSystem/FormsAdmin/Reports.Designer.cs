namespace PresentationLayer.FormsAdmin
{
    partial class Reports
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            inactiveProductsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)inactiveProductsGrid).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // inactiveProductsGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            inactiveProductsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            inactiveProductsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            inactiveProductsGrid.ColumnHeadersHeight = 4;
            inactiveProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            inactiveProductsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            inactiveProductsGrid.GridColor = Color.FromArgb(231, 229, 255);
            inactiveProductsGrid.Location = new Point(158, 190);
            inactiveProductsGrid.Name = "inactiveProductsGrid";
            inactiveProductsGrid.RowHeadersVisible = false;
            inactiveProductsGrid.Size = new Size(490, 336);
            inactiveProductsGrid.TabIndex = 0;
            inactiveProductsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            inactiveProductsGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            inactiveProductsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            inactiveProductsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            inactiveProductsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            inactiveProductsGrid.ThemeStyle.BackColor = Color.White;
            inactiveProductsGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            inactiveProductsGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            inactiveProductsGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            inactiveProductsGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            inactiveProductsGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            inactiveProductsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            inactiveProductsGrid.ThemeStyle.HeaderStyle.Height = 4;
            inactiveProductsGrid.ThemeStyle.ReadOnly = false;
            inactiveProductsGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            inactiveProductsGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            inactiveProductsGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            inactiveProductsGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            inactiveProductsGrid.ThemeStyle.RowsStyle.Height = 25;
            inactiveProductsGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            inactiveProductsGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            inactiveProductsGrid.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(158, 64);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(482, 67);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Out of Stock Products\n";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(inactiveProductsGrid);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(780, 647);
            guna2Panel1.TabIndex = 2;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 647);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            StartPosition = FormStartPosition.Manual;
            Text = "Repots";
            Load += Repots_Load;
            ((System.ComponentModel.ISupportInitialize)inactiveProductsGrid).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView inactiveProductsGrid;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}