using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Expense_
{
    /// <summary>
    /// Interaction logic for Reportxaml.xaml
    /// </summary>
    public partial class Reportxaml : Page
    {
        public Reportxaml()
        {
            InitializeComponent();
        }
        
    }
    public void ShowTheReport()
    {
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-45H0ONO\\SQLEXPRESS;Initial Catalog = WPF_Project;Inter");
        conn.Open();

        SqlCommand cmd = new SqlCommand("SELECT * FROM WPF_Project WHERE Names = @name", conn);
        cmd.Parameters.AddWithValue("@name", report.FN);
    }
}
