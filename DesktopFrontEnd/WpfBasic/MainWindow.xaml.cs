using System.Windows;

namespace WpfBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isDataDirty = false;

        public MainWindow()
        {
            InitializeComponent();
            //this.SizeToContent = SizeToContent.Width;
            this.ResizeMode = ResizeMode.CanMinimize;
            this.ShowInTaskbar = false;
        }

        private void Add_Name(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textName.Text) && !listNames.Items.Contains(textName.Text))
            {
                listNames.Items.Add(textName.Text);
                MessageBox.Show($"{textName.Text} - is added successfully.");
                textName.Clear();
            }
            else
            {
                MessageBox.Show($"Can't add {textName.Text}, as it is already added.", "Error!");
            }
        }

        private void fileExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Close the current window
            this.Close();
        }

        private void UserConfirmationOnWindowClose(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this._isDataDirty)
            {
                var result = MessageBox.Show("Document has changed, close without saving?", "Question", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void textChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            this._isDataDirty = true;
        }
    }
}
