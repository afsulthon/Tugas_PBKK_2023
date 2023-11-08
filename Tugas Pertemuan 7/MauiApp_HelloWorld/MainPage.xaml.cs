namespace MauiApp_HelloWorld
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterBtn.Text = $"Diklik {count} kali";
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}