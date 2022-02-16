using System.Security.Cryptography;

namespace CalcularHash
{
    public partial class FrmCalcularHash : Form
    {
        public FrmCalcularHash()
        {
            InitializeComponent();

            txtArquivo.PlaceholderText = "Selecione um arquivo para calcular o Hash";

        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            txtSHA256.Text = "";
            txtSHA512.Text = "";
            txtArquivo.Text = "";

            ofdlg1.FileName = txtArquivo.Text;
            if (ofdlg1.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = ofdlg1.FileName;
            }
        }

        private SHA256 sha256 = SHA256.Create();

        private byte[] Getsha256(string arquivo)
        {
                FileStream stream = File.OpenRead(arquivo);
                return sha256.ComputeHash(stream);
        }

        private SHA512 sha512 = SHA512.Create();

        private byte[] Getsha512(string arquivo)
        {
            FileStream stream = File.OpenRead(arquivo);
            return sha512.ComputeHash(stream);
        }

        public static string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes)
            {
                result += b.ToString("x2");
            }
            return result;
        }

        private void btnCalcularHash_Click(object sender, EventArgs e)
        {
            if (txtArquivo.Text.Length == 0)
            {
                MessageBox.Show("É necessário selecionar um arquivo para calcular o Hash", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtSHA256.Text = BytesToString(Getsha256(txtArquivo.Text));
                txtSHA512.Text = BytesToString(Getsha512(txtArquivo.Text));
            }
        }

        private void btnCopiarHash_Click(object sender, EventArgs e)
        {
            if (txtSHA256.Text.Length == 0)
            {
                MessageBox.Show("É necessário calcular um Hash antes de poder copiar um Hash!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clipboard.SetText(txtSHA256.Text);

            }
        }

        private void btnCopiarSha512_Click(object sender, EventArgs e)
        {
            if (txtSHA512.Text.Length == 0)
            {
                MessageBox.Show("É necessário calcular um Hash antes de poder copiar um Hash!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clipboard.SetText(txtSHA512.Text);

            }
        }
    }
}