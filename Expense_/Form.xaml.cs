using System;
using System.Collections.Generic;
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

    public partial class Form : Page
    {

        Person person = new Person()
        {
            FN = "Ahmed",
            LN = "Mostafa",
            Email = "ahmed22@gsm",
            Address = "massrrrr",
            Phone = 6

        };
        public Form()
        {
            InitializeComponent();

        }

        public class Person
        {
            public Person()
            {

            }
            public string FN { get; set; }
            public string LN {  get; set; }
            public string Email { get; set; }
            public int Phone { get; set; }
            public string Address { get; set; }
        }
    }
}
