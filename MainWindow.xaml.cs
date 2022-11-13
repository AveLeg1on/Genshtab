using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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



namespace Genshtab
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value1;
       
        
        public MainWindow()
        {
            InitializeComponent();
           

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str=Convert.ToString(Bagage.Text);   
            string Name=Convert.ToString(Item.Text);

            double.TryParse(ves.Text, out value1);
            Listik.Items.Add(str + " " + Name + " " + " " + value1);
            int tmp = Listik.Items.Count;
            Airport air= new Airport(tmp, value1);
            value1=air.Calculation();
           
           





        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
       
        
                var sIndex = Listik.SelectedItems;

                string res;

            foreach (string it in sIndex)
            {
                int tmp = it.LastIndexOf(" ");
                res = it.Substring(tmp);
                if (Convert.ToDouble(res) - value1 <= 0.3) { answer.Content = (string)Listik.SelectedItem; } else { answer.Content = "Элемент не являктся заявленным"; };


             }

               
           
        }
        public double GetVal()
        {
            return value1;  
        }
  }   }
