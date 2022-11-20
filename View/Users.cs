using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data;
using MySql.Data.MySqlClient;

namespace gestionBibiothequeV2.View
{
    public partial class Users : Form
    {
        string para = "SERVER=127.0.0.1; DATABASE=bd-bibiotheque; UID=root; PASSWORD=";
        private MySqlConnection conx;
        DataTable dataTable = new DataTable();
        int crrRowIndex;
        public Users()
        {
           
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}
