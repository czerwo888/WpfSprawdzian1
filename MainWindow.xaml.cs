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

namespace wpfSprawdzian1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    // Obsługa przycisku Stwórz - tworzenie przycisków
    private void CreateButton_Click(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(numberTextBox.Text, out int count) && count >= 1 && count <= 3)
        {
            buttonsPanel.Children.Clear();
            for (int i = 1; i <= count; i++)
            {
                Button button = new Button
                {
                    Content = i.ToString(),
                    Margin = new Thickness(5)
                };
                buttonsPanel.Children.Add(button);
            }
        }
        else
        {
            MessageBox.Show("Proszę podać wartość od 1 do 3.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    // Obsługa suwaka do zmiany rozmiaru czcionki przycisku "Stwórz"
    private void FontSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        createButton.FontSize = fontSizeSlider.Value;
    }

    // Obsługa przycisku WPISZ - otwieranie nowego okna
    private void EnterButton_Click(object sender, RoutedEventArgs e)
    {
        NoweOkno noweOkno = new NoweOkno();
        if (noweOkno.ShowDialog() == true)
        {
            displayTextBlock.Text = NoweOkno.wprowadzonyTekst;
        }
    }
    
}