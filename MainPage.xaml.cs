namespace TestSearchBarFocus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            searchBar.Focused += OnFocused;
            searchBar.Unfocused += OnUnfocused;
        }

        void OnFocused(object sender, EventArgs e)
        {
            label.Text = "Focused";
        }

        void OnUnfocused(object sender, EventArgs e)
        {
            label.Text = "Unfocused";
        }
    }

}
