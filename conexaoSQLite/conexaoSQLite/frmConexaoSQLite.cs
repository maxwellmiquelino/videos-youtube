using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexaoSQLite
{
    public partial class frmConexaoSQLite : Form
    {
        public frmConexaoSQLite()
        {
            InitializeComponent();
        }

        private string strConexao = String.Format(@"Data Source={0}\{1}",
                                                   Application.StartupPath,
                                                   "cnxSQLite.db;");
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using(SQLiteConnection cnx = new SQLiteConnection(strConexao))
                {
                    if (cnx.State == ConnectionState.Closed)
                    {
                        cnx.Open();
                        label1.Text = "Conexão com SQLite efetuado com sucesso !!!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
