using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PaymentSuppliersLibrary
{
    public class PaymentDetails
    {
        private string SupplierName { get; set; }
        private string LogoUrl { get; set; }
       
        public void getPaymentMobile(string SupplierName, string LogoUrl)
        {           
            Window w = new Window();
            w.Height = 600;
            w.Width = 600;
            w.Show();

            Image imgSup = new Image
            {
                Source = new BitmapImage(new Uri(LogoUrl)),
                Height = 60,
                Width = 60,
                Margin = new Thickness(5)
                
            };
            TextBlock tbxName = new TextBlock
            {
                Text = SupplierName,
                Width = 200,
                Padding = new Thickness(12),
                Margin = new Thickness(10)
            };
                      
            WrapPanel wp = new WrapPanel
            {
                
                Margin = new Thickness(10)
            };

            wp.Children.Add(imgSup);
            wp.Children.Add(tbxName);


            Label lblSum = new Label
            {
                Content = "Введите сумму к оплате",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp1 = new WrapPanel();
            wp1.Children.Add(lblSum);
            wp1.Children.Add(tb);

            Label lblSum1 = new Label
            {
                Content = "Введите номер контракта",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb1 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp2 = new WrapPanel();
            wp1.Children.Add(lblSum1);
            wp1.Children.Add(tb1);

            Label lblSum2 = new Label
            {
                Content = "Введите номер телефона",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb2 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp3 = new WrapPanel();
            wp1.Children.Add(lblSum2);
            wp1.Children.Add(tb2);


            Button btn = new Button
            {
                Width = 150,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10),
                Content = "Оплатить"
            };           

            StackPanel sp = new StackPanel
            {
                Orientation = Orientation.Vertical
            };          
            sp.Children.Add(wp1);
            sp.Children.Add(wp2);
            sp.Children.Add(wp3);
            sp.Children.Add(btn);

            Grid gr = new Grid();
            gr.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80.0) });
            gr.RowDefinitions.Add(new RowDefinition());

            gr.Children.Add(wp);
            gr.Children.Add(sp);

            Grid.SetRow(wp, 0);
            Grid.SetRow(sp, 1);

            w.Content = gr;

        }

        public void getPaymentAuto(string SupplierName, string LogoUrl)
        {
            Window w = new Window();
            w.Height = 600;
            w.Width = 600;
            w.Show();

            Image imgSup = new Image
            {
                Source = new BitmapImage(new Uri(LogoUrl)),
                Height = 60,
                Width = 60,
                Margin = new Thickness(5)

            };
            TextBlock tbxName = new TextBlock
            {
                Text = SupplierName,
                Width = 200,
                Padding = new Thickness(12),
                Margin = new Thickness(10)
            };

            WrapPanel wp = new WrapPanel
            {

                Margin = new Thickness(10)
            };

            wp.Children.Add(imgSup);
            wp.Children.Add(tbxName);


            Label lblSum = new Label
            {
                Content = "Введите ваш ИИН",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp1 = new WrapPanel();
            wp1.Children.Add(lblSum);
            wp1.Children.Add(tb);

            Label lblSum1 = new Label
            {
                Content = "Введите сумму к оплате",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb1 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp2 = new WrapPanel();
            wp1.Children.Add(lblSum1);
            wp1.Children.Add(tb1);

            Label lblSum2 = new Label
            {
                Content = "Введите гос.номер автомобиля",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb2 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp3 = new WrapPanel();
            wp1.Children.Add(lblSum2);
            wp1.Children.Add(tb2);


            Button btn = new Button
            {
                Width = 150,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10),
                Content = "Оплатить"
            };

            StackPanel sp = new StackPanel
            {
                Orientation = Orientation.Vertical
            };
            sp.Children.Add(wp1);
            sp.Children.Add(wp2);
            sp.Children.Add(wp3);
            sp.Children.Add(btn);

            Grid gr = new Grid();
            gr.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80.0) });
            gr.RowDefinitions.Add(new RowDefinition());

            gr.Children.Add(wp);
            gr.Children.Add(sp);

            Grid.SetRow(wp, 0);
            Grid.SetRow(sp, 1);

            w.Content = gr;

        }

        public void getPaymentBeaty(string SupplierName, string LogoUrl)
        {
            Window w = new Window();
            w.Height = 600;
            w.Width = 600;
            w.Show();

            Image imgSup = new Image
            {
                Source = new BitmapImage(new Uri(LogoUrl)),
                Height = 60,
                Width = 60,
                Margin = new Thickness(5)

            };
            TextBlock tbxName = new TextBlock
            {
                Text = SupplierName,
                Width = 200,
                Padding = new Thickness(12),
                Margin = new Thickness(10)
            };

            WrapPanel wp = new WrapPanel
            {

                Margin = new Thickness(10)
            };

            wp.Children.Add(imgSup);
            wp.Children.Add(tbxName);


            Label lblSum = new Label
            {
                Content = "Введите сумму к оплате",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp1 = new WrapPanel();
            wp1.Children.Add(lblSum);
            wp1.Children.Add(tb);

            Label lblSum1 = new Label
            {
                Content = "Введите название услуги",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb1 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp2 = new WrapPanel();
            wp1.Children.Add(lblSum1);
            wp1.Children.Add(tb1);            


            Button btn = new Button
            {
                Width = 150,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10),
                Content = "Оплатить"
            };

            StackPanel sp = new StackPanel
            {
                Orientation = Orientation.Vertical
            };
            sp.Children.Add(wp1);
            sp.Children.Add(wp2);           
            sp.Children.Add(btn);

            Grid gr = new Grid();
            gr.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80.0) });
            gr.RowDefinitions.Add(new RowDefinition());

            gr.Children.Add(wp);
            gr.Children.Add(sp);

            Grid.SetRow(wp, 0);
            Grid.SetRow(sp, 1);

            w.Content = gr;

        }

        public void getPaymentEducation(string SupplierName, string LogoUrl)
        {
            Window w = new Window();
            w.Height = 600;
            w.Width = 600;
            w.Show();

            Image imgSup = new Image
            {
                Source = new BitmapImage(new Uri(LogoUrl)),
                Height = 60,
                Width = 60,
                Margin = new Thickness(5)

            };
            TextBlock tbxName = new TextBlock
            {
                Text = SupplierName,
                Width = 200,
                Padding = new Thickness(12),
                Margin = new Thickness(10)
            };

            WrapPanel wp = new WrapPanel
            {

                Margin = new Thickness(10)
            };

            wp.Children.Add(imgSup);
            wp.Children.Add(tbxName);


            Label lblSum = new Label
            {
                Content = "Введите название факультета",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp1 = new WrapPanel();
            wp1.Children.Add(lblSum);
            wp1.Children.Add(tb);

            Label lblSum1 = new Label
            {
                Content = "Введите название специальности",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb1 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp2 = new WrapPanel();
            wp1.Children.Add(lblSum1);
            wp1.Children.Add(tb1);

            Label lblSum2 = new Label
            {
                Content = "Введите сумму к оплате",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb2 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp3 = new WrapPanel();
            wp1.Children.Add(lblSum2);
            wp1.Children.Add(tb2);


            Button btn = new Button
            {
                Width = 150,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10),
                Content = "Оплатить"
            };

            StackPanel sp = new StackPanel
            {
                Orientation = Orientation.Vertical
            };
            sp.Children.Add(wp1);
            sp.Children.Add(wp2);
            sp.Children.Add(wp3);
            sp.Children.Add(btn);

            Grid gr = new Grid();
            gr.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80.0) });
            gr.RowDefinitions.Add(new RowDefinition());

            gr.Children.Add(wp);
            gr.Children.Add(sp);

            Grid.SetRow(wp, 0);
            Grid.SetRow(sp, 1);

            w.Content = gr;

        }

        public void getPaymentJustice(string SupplierName, string LogoUrl)
        {
            Window w = new Window();
            w.Height = 600;
            w.Width = 600;
            w.Show();

            Image imgSup = new Image
            {
                Source = new BitmapImage(new Uri(LogoUrl)),
                Height = 60,
                Width = 60,
                Margin = new Thickness(5)

            };
            TextBlock tbxName = new TextBlock
            {
                Text = SupplierName,
                Width = 200,
                Padding = new Thickness(12),
                Margin = new Thickness(10)
            };

            WrapPanel wp = new WrapPanel
            {

                Margin = new Thickness(10)
            };

            wp.Children.Add(imgSup);
            wp.Children.Add(tbxName);


            Label lblSum = new Label
            {
                Content = "Введите сумму к оплате",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp1 = new WrapPanel();
            wp1.Children.Add(lblSum);
            wp1.Children.Add(tb);

            Label lblSum1 = new Label
            {
                Content = "Укажите размер пени",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb1 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp2 = new WrapPanel();
            wp1.Children.Add(lblSum1);
            wp1.Children.Add(tb1);

            Label lblSum2 = new Label
            {
                Content = "Введите ваш ИИН",
                Margin = new Thickness(10),
                Width = 200
            };

            TextBox tb2 = new TextBox
            {
                Width = 200,
                Height = 30
            };

            WrapPanel wp3 = new WrapPanel();
            wp1.Children.Add(lblSum2);
            wp1.Children.Add(tb2);


            Button btn = new Button
            {
                Width = 150,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10),
                Content = "Оплатить"
            };

            StackPanel sp = new StackPanel
            {
                Orientation = Orientation.Vertical
            };
            sp.Children.Add(wp1);
            sp.Children.Add(wp2);
            sp.Children.Add(wp3);
            sp.Children.Add(btn);

            Grid gr = new Grid();
            gr.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80.0) });
            gr.RowDefinitions.Add(new RowDefinition());

            gr.Children.Add(wp);
            gr.Children.Add(sp);

            Grid.SetRow(wp, 0);
            Grid.SetRow(sp, 1);

            w.Content = gr;

        }
    }
}
