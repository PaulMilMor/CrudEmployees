using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEmployees
{
    public partial class Payment : Form
    {
        Conexion c = null;
        DataSet ds = null;
        //List<String> deptnums;
        Panel[] panels;
        Button[] addButtons;
        DataGridView[] tables;
        public Payment()
        {
            InitializeComponent();
            
        }

        

        
    }
}
