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

namespace WpfGithubDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<string> Autok=new List<string>() {"Skoda","Fiat","Skoda","Ford","Ford","Suzuki","Toyota","Toyota" };
    public MainWindow()
    {
        InitializeComponent();
        var autokUnique = Autok.Distinct();
        comboList.ItemsSource = autokUnique;
    }
}