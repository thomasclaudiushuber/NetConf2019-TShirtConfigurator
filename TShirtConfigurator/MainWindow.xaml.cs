using System.Windows;
using System.Windows.Media;
using TShirtConfigurator.Dialogs;

namespace TShirtConfigurator
{
  public partial class MainWindow : Window
  {
    public Color? _currentColor;
    public MainWindow()
    {
      InitializeComponent();
      _currentColor = Colors.Yellow;
      UpdateUI();
    }

    private void ButtonChangeColor_Click(object sender, RoutedEventArgs e)
    {
      if (ColorDialogHelper.ShowDialog(ref _currentColor))
      {
        UpdateUI();
      }
    }

    private void UpdateUI()
    {
      txtColor.Text = _currentColor.ToString();
      tshirtBrush.Color = _currentColor.Value;
    }
  }
}
