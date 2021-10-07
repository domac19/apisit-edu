using System;
using System.Threading.Tasks;
using System.Windows;

namespace asynchronousExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Task<string[]> task = new Task<string[]>(Fruit);            

            var getFruit = Fruit();
            foreach (var fruit in getFruit)
            {
                await Task.Delay(2000);
                MessageBox.Show($"{fruit} added to your bag");
            }
        }
        public string[] Fruit()
        {
            string[] allFruit = { "Banana", "Apple", "Grapefruit", "Orange", "Strawberry" };
            Array.Sort(allFruit);

            return allFruit;
        }
    }
}
