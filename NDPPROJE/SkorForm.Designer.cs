
namespace NDPPROJE
{
    partial class SkorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgSkor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.oYUNCUADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOYUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oYUNDataSet = new NDPPROJE.OYUNDataSet();
            this.t_OYUNTableAdapter = new NDPPROJE.OYUNDataSetTableAdapters.T_OYUNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSkor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOYUNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYUNDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSkor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgSkor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSkor.AutoGenerateColumns = false;
            this.dtgSkor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSkor.BackgroundColor = System.Drawing.Color.White;
            this.dtgSkor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSkor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgSkor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSkor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSkor.ColumnHeadersHeight = 40;
            this.dtgSkor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oYUNCUADDataGridViewTextBoxColumn,
            this.sKORDataGridViewTextBoxColumn});
            this.dtgSkor.DataSource = this.tOYUNBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSkor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgSkor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSkor.EnableHeadersVisualStyles = false;
            this.dtgSkor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgSkor.Location = new System.Drawing.Point(0, 0);
            this.dtgSkor.Name = "dtgSkor";
            this.dtgSkor.RowHeadersVisible = false;
            this.dtgSkor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSkor.Size = new System.Drawing.Size(263, 198);
            this.dtgSkor.TabIndex = 46;
            this.dtgSkor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgSkor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgSkor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgSkor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgSkor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgSkor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgSkor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgSkor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.dtgSkor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgSkor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgSkor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgSkor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgSkor.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgSkor.ThemeStyle.ReadOnly = false;
            this.dtgSkor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgSkor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgSkor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgSkor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgSkor.ThemeStyle.RowsStyle.Height = 22;
            this.dtgSkor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgSkor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // oYUNCUADDataGridViewTextBoxColumn
            // 
            this.oYUNCUADDataGridViewTextBoxColumn.DataPropertyName = "OYUNCU_AD";
            this.oYUNCUADDataGridViewTextBoxColumn.HeaderText = "OYUNCU ADI";
            this.oYUNCUADDataGridViewTextBoxColumn.Name = "oYUNCUADDataGridViewTextBoxColumn";
            this.oYUNCUADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sKORDataGridViewTextBoxColumn
            // 
            this.sKORDataGridViewTextBoxColumn.DataPropertyName = "SKOR";
            this.sKORDataGridViewTextBoxColumn.HeaderText = "SKOR";
            this.sKORDataGridViewTextBoxColumn.Name = "sKORDataGridViewTextBoxColumn";
            this.sKORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOYUNBindingSource
            // 
            this.tOYUNBindingSource.DataMember = "T_OYUN";
            this.tOYUNBindingSource.DataSource = this.oYUNDataSet;
            // 
            // oYUNDataSet
            // 
            this.oYUNDataSet.DataSetName = "OYUNDataSet";
            this.oYUNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_OYUNTableAdapter
            // 
            this.t_OYUNTableAdapter.ClearBeforeFill = true;
            // 
            // SkorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 198);
            this.Controls.Add(this.dtgSkor);
            this.MaximizeBox = false;
            this.Name = "SkorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skorlar";
            this.Load += new System.EventHandler(this.SkorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSkor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOYUNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYUNDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtgSkor;
        private OYUNDataSet oYUNDataSet;
        private System.Windows.Forms.BindingSource tOYUNBindingSource;
        private OYUNDataSetTableAdapters.T_OYUNTableAdapter t_OYUNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oYUNCUADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKORDataGridViewTextBoxColumn;
    }
}