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
using WpfApp1.Models;
using WpfApp1.ViewModels;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    MainViewModel mainViewModel;

   
    public MainWindow()
    {
        InitializeComponent();
        mainViewModel = new MainViewModel();
        mainViewModel.ProgressValue = 30;
        DataContext = mainViewModel;
    }

    private void btnTest1_Click(object sender, RoutedEventArgs e)
    {
        labelTest1.Content = checkBox1.IsChecked;
        //MessageBox.Show(textBox1.Text);


        List<User> myList1 = new List<User>();


        User userA = new User();

        userA.UserImg = @"C:\\Users\\idodo\\Documents\\Study2_C\\개발자 Park\\WpfApp\\WpfApp1\\WpfApp1\\Resources\\cat.jpg";
        userA.Name = "hada";
        userA.UserAge= 15;
       
        User userB = new User();

        userB.UserImg = @"C:\\Users\\idodo\\Documents\\Study2_C\\개발자 Park\\WpfApp\\WpfApp1\\WpfApp1\\Resources\\bird.jpg";
        userB.Name = "daha";
        userB.UserAge = 26;
        
            
            
        myList1.Add(userA);
        myList1.Add(userB);

        listView1.ItemsSource = myList1;


        mainViewModel.ProgressValue = 100;

    }
}