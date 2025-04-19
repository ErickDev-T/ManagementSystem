namespace PresentationLayer.Forms_Admin
{
    partial class ProductsForm
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
            ProductsTabla = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProductsTabla).BeginInit();
            SuspendLayout();
            // 
            // ProductsTabla
            // 
            ProductsTabla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 224, 244);
            ProductsTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductsTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductsTabla.ColumnHeadersHeight = 17;
            ProductsTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 186, 231);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProductsTabla.DefaultCellStyle = dataGridViewCellStyle3;
            ProductsTabla.GridColor = Color.FromArgb(187, 220, 242);
            ProductsTabla.Location = new Point(167, 149);
            ProductsTabla.Name = "ProductsTabla";
            ProductsTabla.ReadOnly = true;
            ProductsTabla.RowHeadersVisible = false;
            ProductsTabla.Size = new Size(757, 322);
            ProductsTabla.TabIndex = 0;
            ProductsTabla.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            ProductsTabla.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            ProductsTabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProductsTabla.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProductsTabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProductsTabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProductsTabla.ThemeStyle.BackColor = Color.White;
            ProductsTabla.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            ProductsTabla.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 152, 219);
            ProductsTabla.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductsTabla.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            ProductsTabla.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProductsTabla.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProductsTabla.ThemeStyle.HeaderStyle.Height = 17;
            ProductsTabla.ThemeStyle.ReadOnly = true;
            ProductsTabla.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            ProductsTabla.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductsTabla.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ProductsTabla.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            ProductsTabla.ThemeStyle.RowsStyle.Height = 25;
            ProductsTabla.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 186, 231);
            ProductsTabla.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            ProductsTabla.CellContentClick += ProductsTabla_CellContentClick;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 660);
            Controls.Add(ProductsTabla);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsTabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ProductsTabla;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Stock;
    }
}