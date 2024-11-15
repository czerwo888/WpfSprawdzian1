using System.Windows;

namespace wpfSprawdzian1;

public partial class NoweOkno : Window
{
    public NoweOkno()
    {
        InitializeComponent();
    }
    
    public static string wprowadzonyTekst { get; private set; }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        wprowadzonyTekst = inputTextBox.Text;
        DialogResult = true;
        Close();
    }
}