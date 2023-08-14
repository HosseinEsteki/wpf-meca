using DataAccess.Data;
using DataAccess.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFMecaApp
{
    public partial class AddEditUserWindow : Window
    {
        public User User;
        UserDataAccess userDataAccess = new UserDataAccess();
        public AddEditUserWindow()
        {
            InitializeComponent();
        }
        public AddEditUserWindow(User user)
        {
            InitializeComponent();
            this.User = user;
            textboxUserName.Text = user.Name;
            textboxPhoneNumber.Text = user.PhoneNumber;
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(User == null)
            {
                User user = new User
                {
                    Name = textboxUserName.Text.Trim(),
                    PhoneNumber = textboxPhoneNumber.Text.Trim(),
                };
                userDataAccess.Add(user);
                MessageBox.Show(Messages.InsertMessage);
            }
            else
            {
                User.PhoneNumber = textboxPhoneNumber.Text.Trim();
                User.Name= textboxUserName.Text.Trim();
                userDataAccess.Update(User);
                MessageBox.Show(Messages.UpdateMessage);

            }
            this.Close();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void textboxPhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            CheckInput.Number(e);
        }
        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnSubmit.IsEnabled=
                textboxPhoneNumber.Text.Trim().Length==11
                &&textboxUserName.Text.Trim().Length>0;
        }
    }
}
