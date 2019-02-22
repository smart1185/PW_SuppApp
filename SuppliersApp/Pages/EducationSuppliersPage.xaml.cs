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
    /// Логика взаимодействия для EducationSuppliersPage.xaml
    /// </summary>
    public partial class EducationSuppliersPage : Page
    {
        public static string supplierName { get; set; }
        public static string supplierImageUrl { get; set; }
        public EducationSuppliersPage()
        {
            InitializeComponent();
        }

        private void turan_Click(object sender, RoutedEventArgs e)
        {
            supplierName = tbxTuran.Text;
            supplierImageUrl = turanSrc.Source.ToString();

            AppDomain AppExtended = AppDomain.CreateDomain("Payment");
            Assembly asm = Assembly.LoadFrom(@"C:\Users\safha\Documents\Visual Studio 2015\Projects\SuppliersApp\PaymentSuppliersLibrary\bin\Debug\PaymentSuppliersLibrary.dll");

            Type t = asm.GetTypes()[0];

            object obj = Activator.CreateInstance(t);

            MethodInfo method = obj.GetType().GetMethod("getPaymentEducation");
            method.Invoke(obj, new object[] { supplierName, supplierImageUrl });

            AppDomain.Unload(AppExtended);

        }

        private void eurasian_Click(object sender, RoutedEventArgs e)
        {
            supplierName = tbxEuras.Text;
            supplierImageUrl = euras.Source.ToString();

            AppDomain AppExtended = AppDomain.CreateDomain("Payment");
            Assembly asm = Assembly.LoadFrom(@"C:\Users\safha\Documents\Visual Studio 2015\Projects\SuppliersApp\PaymentSuppliersLibrary\bin\Debug\PaymentSuppliersLibrary.dll");

            Type t = asm.GetTypes()[0];

            object obj = Activator.CreateInstance(t);

            MethodInfo method = obj.GetType().GetMethod("getPaymentEducation");
            method.Invoke(obj, new object[] { supplierName, supplierImageUrl });

            AppDomain.Unload(AppExtended);

        }
    }
}
