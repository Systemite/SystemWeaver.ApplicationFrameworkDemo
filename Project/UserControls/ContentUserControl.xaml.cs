using System.Windows.Controls;
using SystemWeaverAPI;

namespace SystemWeaver.ApplicationFrameworkDemo.UserControls
{
    /// <summary>
    /// Interaction logic for ContentUserControl.xaml
    /// </summary>
    public partial class ContentUserControl : UserControl
    {
        public ContentUserControl()
        {
            InitializeComponent();

            userTextBlock.Text = "Current user: " + SWConnection.Instance.Broker.CurrentUser.Name;
            lastLoginTextBlock.Text = "Last login: " + SWConnection.Instance.Broker.CurrentUser.LastLogin;
        }
    }
}
