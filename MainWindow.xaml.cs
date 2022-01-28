using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WpfApplab_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> style = new List<string>() { "Светлая тема", "Тёмная тема" };
            styleBox.ItemsSource = style;
            styleBox.SelectionChanged += ThemeChange;
            styleBox.SelectedIndex = 0;
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            int styleIndex = styleBox.SelectedIndex;
            Uri uri = new Uri("Light.xaml", UriKind.Relative);
            if (styleIndex == 1)
            {
                uri= new Uri("Dark.xaml", UriKind.Relative);
            }
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }

        ////private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        ////{
        ////    string fontName = (sender as ComboBox).SelectedItem.ToString();
        ////    if (textbox != null)
        ////    {
        ////        textbox.FontFamily = new FontFamily(fontName);
        ////    }

        ////}

        ////private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        ////{
        ////    string fontsize = (sender as ComboBox).SelectedItem.ToString();
        ////    if (textbox != null)
        ////    {
        ////        textbox.FontSize = Convert.ToDouble(fontsize);
        ////    }

        ////}

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            if (textbox.FontWeight == FontWeights.Normal)
            {
                textbox.FontWeight = FontWeights.Bold;
            }
            else
            {
                textbox.FontWeight = FontWeights.Normal;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textbox.FontStyle == FontStyles.Normal)
            {
                textbox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textbox.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textbox.TextDecorations == TextDecorations.Underline)
            {
                textbox.TextDecorations = new TextDecorationCollection();
            }
            else
            {
                textbox.TextDecorations = TextDecorations.Underline;
            }
        }
        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            textbox.Foreground = Brushes.Black;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textbox.Foreground = Brushes.Red;

        }
        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            textbox.Foreground = Brushes.White;
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExitCanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            if (textbox != null && textbox.Text.Length == 0)
            { e.CanExecute = true; }
            else { e.CanExecute = false; }
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textbox.Text);
            }
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textbox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}
