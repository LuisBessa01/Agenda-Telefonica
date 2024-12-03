namespace Agenda_Telefonica.Views
{
    partial class frmCategorias
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
            label1 = new Label();
            txtCategoria = new TextBox();
            label2 = new Label();
            btnAddCategoria = new Button();
            dgvCategorias = new DataGridView();
            btnDelete = new Button();
            btnRenomear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 36);
            label1.Name = "label1";
            label1.Size = new Size(279, 41);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(64, 137);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(254, 76);
            txtCategoria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 113);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome da categoria";
            // 
            // btnAddCategoria
            // 
            btnAddCategoria.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategoria.Location = new Point(64, 269);
            btnAddCategoria.Margin = new Padding(3, 4, 3, 4);
            btnAddCategoria.Name = "btnAddCategoria";
            btnAddCategoria.Size = new Size(255, 61);
            btnAddCategoria.TabIndex = 3;
            btnAddCategoria.Text = "Adicionar";
            btnAddCategoria.UseVisualStyleBackColor = true;
            btnAddCategoria.Click += btnAddCategoria_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(411, 36);
            dgvCategorias.Margin = new Padding(3, 4, 3, 4);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(479, 347);
            dgvCategorias.TabIndex = 4;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(897, 352);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRenomear
            // 
            btnRenomear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRenomear.Location = new Point(64, 377);
            btnRenomear.Margin = new Padding(3, 4, 3, 4);
            btnRenomear.Name = "btnRenomear";
            btnRenomear.Size = new Size(255, 61);
            btnRenomear.TabIndex = 8;
            btnRenomear.Text = "Renomear";
            btnRenomear.UseVisualStyleBackColor = true;
            btnRenomear.Click += btnRenomear_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1003, 679);
            Controls.Add(btnRenomear);
            Controls.Add(btnDelete);
            Controls.Add(dgvCategorias);
            Controls.Add(btnAddCategoria);
            Controls.Add(label2);
            Controls.Add(txtCategoria);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategorias";
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoria;
        private Label label2;
        private Button btnAddCategoria;
        private DataGridView dgvCategorias;
        private Button btnDelete;
        private Button btnRenomear;
    }
}