using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.IO;
using Microsoft.Win32;

namespace RealEstate.WPF.View
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow(){ InitializeComponent(); }
                   
        private void tbSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
        //    if (Char.IsDigit(e.Text, 0)) e.Handled = true; //запрет ввода цифр           
        }

        private void tbSearch_PreviewKeyDown(object sender, KeyEventArgs e)
        {       
        //    if (e.Key == Key.Space && (sender as TextBox).Text.Length <= 0 )//запрет первого пробела
        //    e.Handled = true;
        }

        private void tbSurname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
        //    if (Char.IsDigit(e.Text, 0)) e.Handled = true;//запрет ввода цифр
        }

        private void tbName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
        //    if (Char.IsDigit(e.Text, 0)) e.Handled = true;//запрет ввода цифр
        }

        private void tbPatronymic_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
        //    if (Char.IsDigit(e.Text, 0)) e.Handled = true;//запрет ввода цифр
        }
    }
}
       

        
        
    