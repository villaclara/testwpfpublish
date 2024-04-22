using System.Reflection;
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

namespace testpublish.wpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public string VersionText { get; set; } = "";
		public MainWindow()
		{
			InitializeComponent();

			//VersionText = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "0.0.0.0";
			VersionTextBlock.Text = "2.0.0";
		}
	}
}