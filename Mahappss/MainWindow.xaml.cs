using MahApps.Metro.Controls;
using Mahappss.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mahappss
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public string RemainingBalance { get; set; }

        public List<Budget> budgets;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            double balance = 1600;
            RemainingBalance = $"${balance}";

            budgets = new List<Budget>();
        }

        private void NewBudgetButton_Click(object sender, RoutedEventArgs e)
        {
            if (BudgetStackPanel.Visibility == Visibility.Collapsed)
            {
                BudgetStackPanel.Visibility = Visibility.Visible;
            } else
            {
                BudgetStackPanel.Visibility = Visibility.Collapsed;
            }
                
        }

        //private void CreateBudgetButton_Click(object sender, RoutedEventArgs e)
        //{

        //    Budget budget = new Budget
        //    {
        //        StartDate = (DateTime)StartDatePicker.SelectedDate!,
        //        EndDate = (DateTime)EndDatePicker.SelectedDate!,
        //        BudgetAmount = double.Parse(TotalBudgetTextBox.Text)
        //    };

        //    //MessageBox.Show(budget.StartDate.ToString());
        //    budgets.Add(budget);
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateFlyout.IsOpen = true;

        }


    }

}