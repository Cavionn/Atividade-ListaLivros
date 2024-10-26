namespace Atividade_lista_objeto
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
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            txtAutor = new TextBox();
            label4 = new Label();
            txtEditora = new TextBox();
            label5 = new Label();
            txtAno = new TextBox();
            label6 = new Label();
            txtEdicao = new TextBox();
            label7 = new Label();
            txtPaginas = new TextBox();
            label8 = new Label();
            txtIdioma = new TextBox();
            label9 = new Label();
            btnAdd = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            dgvLivros = new DataGridView();
            btnExcluir = new DataGridViewButtonColumn();
            btnEditar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            Edicao = new DataGridViewTextBoxColumn();
            Paginas = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            cmbGeneros = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(17, 45);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(177, 31);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 2;
            label2.Text = "Título do Lívro";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(17, 147);
            txtTitulo.Margin = new Padding(4, 5, 4, 5);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(177, 31);
            txtTitulo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 212);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(17, 242);
            txtAutor.Margin = new Padding(4, 5, 4, 5);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(177, 31);
            txtAutor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 303);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 6;
            label4.Text = "Editora";
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(17, 333);
            txtEditora.Margin = new Padding(4, 5, 4, 5);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(177, 31);
            txtEditora.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 8;
            label5.Text = "Ano";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(230, 45);
            txtAno.Margin = new Padding(4, 5, 4, 5);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(177, 31);
            txtAno.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 117);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 10;
            label6.Text = "Edição";
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(230, 147);
            txtEdicao.Margin = new Padding(4, 5, 4, 5);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(177, 31);
            txtEdicao.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 212);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 12;
            label7.Text = "Páginas";
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(230, 242);
            txtPaginas.Margin = new Padding(4, 5, 4, 5);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(177, 31);
            txtPaginas.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(230, 303);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 14;
            label8.Text = "Idioma";
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(230, 333);
            txtIdioma.Margin = new Padding(4, 5, 4, 5);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(177, 31);
            txtIdioma.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(436, 15);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 16;
            label9.Text = "Gênero";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(436, 93);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 138);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(527, 93);
            btnDel.Margin = new Padding(4, 5, 4, 5);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(87, 138);
            btnDel.TabIndex = 19;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(436, 242);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(179, 118);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvLivros
            // 
            dgvLivros.AllowUserToAddRows = false;
            dgvLivros.AllowUserToDeleteRows = false;
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Columns.AddRange(new DataGridViewColumn[] { btnExcluir, btnEditar, Id, Titulo, Autor, Editora, Ano, Edicao, Paginas, Idioma, Genero });
            dgvLivros.Location = new Point(18, 374);
            dgvLivros.Margin = new Padding(4, 5, 4, 5);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.ReadOnly = true;
            dgvLivros.RowHeadersVisible = false;
            dgvLivros.RowHeadersWidth = 62;
            dgvLivros.RowTemplate.Height = 25;
            dgvLivros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivros.Size = new Size(597, 250);
            dgvLivros.TabIndex = 21;
            dgvLivros.CellContentClick += dgvLivros_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.MinimumWidth = 8;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ReadOnly = true;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            btnExcluir.Width = 150;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 8;
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 150;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.HeaderText = "Identificador";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // Titulo
            // 
            Titulo.DataPropertyName = "Titulo";
            Titulo.HeaderText = "Título do Lívro";
            Titulo.MinimumWidth = 8;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Width = 150;
            // 
            // Autor
            // 
            Autor.DataPropertyName = "Autor";
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 8;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            Autor.Width = 150;
            // 
            // Editora
            // 
            Editora.DataPropertyName = "Editora";
            Editora.HeaderText = "Editora";
            Editora.MinimumWidth = 8;
            Editora.Name = "Editora";
            Editora.ReadOnly = true;
            Editora.Width = 150;
            // 
            // Ano
            // 
            Ano.DataPropertyName = "Ano";
            Ano.HeaderText = "Ano";
            Ano.MinimumWidth = 8;
            Ano.Name = "Ano";
            Ano.ReadOnly = true;
            Ano.Width = 150;
            // 
            // Edicao
            // 
            Edicao.DataPropertyName = "Edicao";
            Edicao.HeaderText = "Edição";
            Edicao.MinimumWidth = 8;
            Edicao.Name = "Edicao";
            Edicao.ReadOnly = true;
            Edicao.Width = 150;
            // 
            // Paginas
            // 
            Paginas.DataPropertyName = "Paginas";
            Paginas.HeaderText = "Páginas";
            Paginas.MinimumWidth = 8;
            Paginas.Name = "Paginas";
            Paginas.ReadOnly = true;
            Paginas.Width = 150;
            // 
            // Idioma
            // 
            Idioma.DataPropertyName = "Idioma";
            Idioma.HeaderText = "Idioma";
            Idioma.MinimumWidth = 8;
            Idioma.Name = "Idioma";
            Idioma.ReadOnly = true;
            Idioma.Width = 150;
            // 
            // Genero
            // 
            Genero.DataPropertyName = "genero";
            Genero.HeaderText = "Gênero";
            Genero.MinimumWidth = 8;
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            Genero.Width = 150;
            // 
            // cmbGeneros
            // 
            cmbGeneros.FormattingEnabled = true;
            cmbGeneros.Items.AddRange(new object[] { "Romance", "Si-Fi", "Comédia", "Drama", "Terror" });
            cmbGeneros.Location = new Point(436, 45);
            cmbGeneros.Margin = new Padding(4, 5, 4, 5);
            cmbGeneros.Name = "cmbGeneros";
            cmbGeneros.Size = new Size(171, 33);
            cmbGeneros.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 685);
            Controls.Add(cmbGeneros);
            Controls.Add(dgvLivros);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(label9);
            Controls.Add(txtIdioma);
            Controls.Add(label8);
            Controls.Add(txtPaginas);
            Controls.Add(label7);
            Controls.Add(txtEdicao);
            Controls.Add(label6);
            Controls.Add(txtAno);
            Controls.Add(label5);
            Controls.Add(txtEditora);
            Controls.Add(label4);
            Controls.Add(txtAutor);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtTitulo;
        private Label label3;
        private TextBox txtAutor;
        private Label label4;
        private TextBox txtEditora;
        private Label label5;
        private TextBox txtAno;
        private Label label6;
        private TextBox txtEdicao;
        private Label label7;
        private TextBox txtPaginas;
        private Label label8;
        private TextBox txtIdioma;
        private Label label9;
        private Button btnAdd;
        private Button btnDel;
        private Button btnUpdate;
        private DataGridView dgvLivros;
        private ComboBox cmbGeneros;
        private DataGridViewButtonColumn btnExcluir;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewTextBoxColumn Edicao;
        private DataGridViewTextBoxColumn Paginas;
        private DataGridViewTextBoxColumn Idioma;
        private DataGridViewTextBoxColumn Genero;
    }
}