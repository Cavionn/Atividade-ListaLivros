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
        }
    }
}