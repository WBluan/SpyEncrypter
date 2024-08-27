using Moving_Image.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Moving_Image.ViewModels
{
    public class MainViewModel
    {
        public void EncryptPassword(string password, Action<string> updateEncryptedTextBox)
        {
            byte[] passwordByte = Encoding.UTF8.GetBytes(password);
            byte[] saltByte = PasswordHasher.GenerateSalt(16);
            byte[] hashedPasswordByte = PasswordHasher.GeneratePasswordHash(passwordByte, saltByte);

            string hashedPasswordString = PasswordHasher.ConvertToBase64String(hashedPasswordByte);
            updateEncryptedTextBox(hashedPasswordString);
         }

    }
}
