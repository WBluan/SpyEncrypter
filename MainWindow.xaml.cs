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
        private string _hashedPassword;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Normal;
        }

        static byte[] GeneratePasswordHash(byte[] plainText, byte[] salt)
        {

            using (var algorithm = new SHA256Managed())
            {
                byte[] plainTextWithSalt = new byte[plainText.Length + salt.Length];

                for (int i = 0; i < plainText.Length; i++)
                {
                    //adiciona byte por byte o conteúdo do texto limpo no texto seguro
                    plainTextWithSalt[i] = plainText[i];
                }
                for (int i = 0; i < salt.Length; i++)
                {
                    //adiciona byte por byte, após o conteúdo texto limpo, os bytes do nosso salt
                    plainTextWithSalt[plainText.Length + i] = salt[i];
                }
                //
                return algorithm.ComputeHash(plainTextWithSalt);

            }
        }
        private byte[] GenerateSalt(int lenght)
        {
            //cria um número criptográfico aleatório
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[lenght];
                //Preenche o sal com uma sequência criptográfica forte
                rng.GetBytes(salt);
                return salt;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string password = inputUserPassword.Password;
            byte[] passwordByte = Encoding.UTF8.GetBytes(password);
            byte[] salt = GenerateSalt(16);
            byte[] hashedPasswordBytes = GeneratePasswordHash(passwordByte, salt);

            _hashedPassword = ConvertToBase64String(hashedPasswordBytes);
            encryptedTextBox.Text = _hashedPassword;
        }

        private string ConvertToBase64String(byte[] encriptedByte)
        {
            string encriptedString = Convert.ToBase64String(encriptedByte);
            return encriptedString;
        }
    }
}