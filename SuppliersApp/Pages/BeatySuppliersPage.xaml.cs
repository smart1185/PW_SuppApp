using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace SuppliersApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для BeatySuppliersPage.xaml
    /// </summary>
    public partial class BeatySuppliersPage : Page
    {
        public static string supplierName { get; set; }
        public static string supplierImageUrl { get; set; }
        public BeatySuppliersPage()
        {
            InitializeComponent();
        }

        private void beaty1_Click(object sender, RoutedEventArgs e)
        {
            supplierName = tbxNail.Text;
            supplierImageUrl = nail.Source.ToString();

            AppDomain AppExtended = AppDomain.CreateDomain("Payment");
            Assembly asm = Assembly.LoadFrom(@"C:\Users\safha\Documents\Visual Studio 2015\Projects\SuppliersApp\PaymentSuppliersLibrary\bin\Debug\PaymentSuppliersLibrary.dll");

            Type t = asm.GetTypes()[0];

            object obj = Activator.CreateInstance(t);

            MethodInfo method = obj.GetType().GetMethod("getPaymentBeaty");
            method.Invoke(obj, new object[] { supplierName, supplierImageUrl });

            AppDomain.Unload(AppExtended);

        }

        private void beaty2_Click(object sender, RoutedEventArgs e)
        {
            supplierName = tbxErm.Text;
            supplierImageUrl = erm.Source.ToString();

            AppDomain AppExtended = AppDomain.CreateDomain("Payment");
            Assembly asm = Assembly.LoadFrom(@"C:\Users\safha\Documents\Visual Studio 2015\Projects\SuppliersApp\PaymentSuppliersLibrary\bin\Debug\PaymentSuppliersLibrary.dll");

            Type t = asm.GetTypes()[0];

            object obj = Activator.CreateInstance(t);

            MethodInfo method = obj.GetType().GetMethod("getPaymentBeaty");
            method.Invoke(obj, new object[] { supplierName, supplierImageUrl });

            AppDomain.Unload(AppExtended);

        }
    }
}
