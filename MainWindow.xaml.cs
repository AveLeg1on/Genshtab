using System;
using System.Windows;



namespace Genshtab
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value1;
        string dubl = "";

        Airport air;

        public MainWindow()
        {
            InitializeComponent();


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = Convert.ToString(Bagage.Text);
            string Name = Convert.ToString(Item.Text);

            double.TryParse(ves.Text, out value1);
            if (value1 < 0)
            {
                value1 = 0;
                MessageBox.Show("Отрицательные килограммы? Серьезно?");
                return;
            }
            Listik.Items.Add(str + " " + Name + " " + " " + value1);
            air.QuantityItems = Listik.Items.Count;
            air.Weight = value1;

            value1 = air.Calculation();

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var sIndex = Listik.SelectedItems;

            string res;

            foreach (string it in sIndex)
            {
                int tmp = it.LastIndexOf(" ");
                res = it.Substring(tmp);
                if (Convert.ToDouble(res) - value1 <= 0.3) { answer.Content = (string)Listik.SelectedItem; } else { answer.Content = "Элемент не является заявленным"; };


            }



        }
        public double GetVal()
        {
            return value1;
        }
        public void SimpleDelete()
        {
            Listik.Items.RemoveAt(Listik.SelectedIndex);
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var sIndex = Listik.SelectedItems;
            foreach (string it in sIndex)
            {
                for (int i = 0; i < it.Length; i++)
                {

                    if (char.IsDigit(Convert.ToChar(it[i])) || char.IsPunctuation(it[i]))
                    {
                        dubl += it[i];
                    }
                }
            }

            air.StepToBack(Convert.ToDouble(dubl));
            dubl = "";
            if (Listik.SelectedIndex != -1)
                Listik.Items.RemoveAt(Listik.SelectedIndex);
            else
                MessageBox.Show("выберите элемент");

        }
    }
}
