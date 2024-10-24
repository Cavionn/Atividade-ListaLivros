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
            Id = new DataGridViewTextBoxColumn();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            Edicao = new DataGridViewTextBoxColumn();
            Paginas = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            btnExcluir = new DataGridViewButtonColumn();
            btnEditar = new DataGridViewButtonColumn();
            cbGeneros = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Título do Lívro";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 88);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 23);
            txtTitulo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(12, 145);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(125, 23);
            txtAutor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 182);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Editora";
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(12, 200);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(125, 23);
            txtEditora.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 9);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 8;
            label5.Text = "Ano";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(161, 27);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(125, 23);
            txtAno.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(161, 70);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Edição";
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(161, 88);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(125, 23);
            txtEdicao.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(161, 127);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 12;
            label7.Text = "Páginas";
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(161, 145);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(125, 23);
            txtPaginas.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(161, 182);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 14;
            label8.Text = "Idioma";
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(161, 200);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(125, 23);
            txtIdioma.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(305, 9);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 16;
            label9.Text = "Gênero";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(305, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(58, 83);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(369, 56);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(61, 83);
            btnDel.TabIndex = 19;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(305, 145);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 71);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvLivros
            // 
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Columns.AddRange(new DataGridViewColumn[] { Id, Título, Autor, Editora, Ano, Edicao, Paginas, Idioma, btnExcluir, btnEditar });
            dgvLivros.Location = new Point(12, 229);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.RowHeadersVisible = false;
            dgvLivros.RowTemplate.Height = 25;
            dgvLivros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivros.Size = new Size(418, 150);
            dgvLivros.TabIndex = 21;
            // 
            // Id
            // 
            Id.HeaderText = "Identificador";
            Id.Name = "Id";
            // 
            // Título
            // 
            Título.HeaderText = "Título do Lívro";
            Título.Name = "Título";
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            // 
            // Editora
            // 
            Editora.HeaderText = "Editora";
            Editora.Name = "Editora";
            // 
            // Ano
            // 
            Ano.HeaderText = "Ano";
            Ano.Name = "Ano";
            // 
            // Edicao
            // 
            Edicao.HeaderText = "Edição";
            Edicao.Name = "Edicao";
            // 
            // Paginas
            // 
            Paginas.HeaderText = "Páginas";
            Paginas.Name = "Paginas";
            // 
            // Idioma
            // 
            Idioma.HeaderText = "Idioma";
            Idioma.Name = "Idioma";
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            // 
            // cbGeneros
            // 
            cbGeneros.FormattingEnabled = true;
            cbGeneros.Items.AddRange(new object[] { "Romance", "Si-Fi", "Comédia", "Drama", "Terror" });
            cbGeneros.Location = new Point(305, 27);
            cbGeneros.Name = "cbGeneros";
            cbGeneros.Size = new Size(121, 23);
            cbGeneros.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 411);
            Controls.Add(cbGeneros);
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewTextBoxColumn Edicao;
        private DataGridViewTextBoxColumn Paginas;
        private DataGridViewTextBoxColumn Idioma;
        private DataGridViewButtonColumn btnExcluir;
        private DataGridViewButtonColumn btnEditar;
        private ComboBox cbGeneros;
    }
}