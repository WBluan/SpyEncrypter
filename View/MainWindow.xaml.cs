using Moving_Image.ViewModels;
using System.ComponentModel;
using System.Security.Cryptography;
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

namespace Moving_Image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Normal;
            _mainViewModel = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputUserPassword.Password == null) { return; }
            _mainViewModel.EncryptPassword(inputUserPassword.Password, hashedPassword =>
            {
                encryptedTextBox.Text = hashedPassword;
            });
        }

    }
}