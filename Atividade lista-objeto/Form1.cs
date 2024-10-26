using System.ComponentModel;

namespace Atividade_lista_objeto
{

    public partial class Form1 : Form
    {
        private static List<Livros> livros = new List<Livros>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Livros livro = new Livros();

            livro.id = Convert.ToInt32(txtId.Text);
            livro.titulo = txtTitulo.Text;
            livro.autor = txtAutor.Text;
            livro.editora = txtEditora.Text;
            livro.edicao = txtEdicao.Text;
            livro.idioma = txtIdioma.Text;
            livro.ano = Convert.ToInt32(txtAno.Text);
            livro.paginas = Convert.ToInt32(txtPaginas.Text);


            livros.Add(livro);

            string texto = cmbGeneros.Text, genero;
            int index = cmbGeneros.SelectedIndex;

            switch (index)
            {
                case 0:
                    genero = "Romance";
                    break;
                case 1:
                    genero = "Si - Fi";
                    break;
                case 2:
                    genero = "Comédia";
                    break;
                case 3:
                    genero = "Drama";
                    break;
                case 4:
                    genero = "Terror";
                    break;
            }

            livro.genero = cmbGeneros.Text;

            CarregaProdutos();

        }

        private void CarregaProdutos()
        {
            BindingList<Livros> listaProdutos = new BindingList<Livros>();

            foreach (Livros livro in livros)
            {
                listaProdutos.Add(livro);
            }

            dgvLivros.DataSource = listaProdutos;

        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtId.Text);

            Livros livro = livros.Find(x => x.id == idProduto); //X = Produto (Representa os elementos de uma lista || x.id = Produto.id

            DialogResult result = MessageBox.Show("Confirma a Exclusão?", "Excluir",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (livros != null)
                {
                    livros.Remove(livro);
                }
            }

            CarregaProdutos();

            txtId.Clear();
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = Convert.ToInt32(dgvLivros.Rows[e.RowIndex].Cells["id"].Value);
                string operation = dgvLivros.Columns[e.ColumnIndex].Name;

                if (operation == "btnExcluir")
                {
                    DialogResult result = MessageBox.Show("Confirma a Exclusão?", "Excluir",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int idx = livros.FindIndex(x => x.id == id);
                        livros.RemoveAt(idx);

                        CarregaProdutos();
                    }

                    else if(operation == "btnEditar")
                    {

                    }
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Livros livro = new Livros();

            livro.id = Convert.ToInt32(txtId.Text);
            livro.titulo = txtTitulo.Text;
            livro.autor = txtAutor.Text;
            livro.editora = txtEditora.Text;
            livro.edicao = txtEdicao.Text;
            livro.idioma = txtIdioma.Text;
            livro.ano = Convert.ToInt32(txtAno.Text);
            livro.paginas = Convert.ToInt32(txtPaginas.Text);
            livro.genero = cmbGeneros.Text;

            int idLivro = Convert.ToInt32(txtId.Text);
            Livros temp = livros.Find(x => x.id == idLivro);

            if (temp != null)
            {
                int idx = livros.IndexOf(temp);

                if (idx >= 0)
                {
                    livro.id = idLivro;
                    livros[idx] = livro;
                    CarregaProdutos();
                }
            }


        }
    }



    //private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e) // DataGridViewCellEventArgs --> Evento
    //{


    //private Boolean Validador()
    //{
    //    bool validar = true;

    //    if(== "")
    //}

}


