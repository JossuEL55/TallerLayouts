namespace TallerLayouts.Pages
{
    public partial class GridLayout : ContentPage
    {
        public GridLayout()
        {
            InitializeComponent();
        }

        private async void OnNavigateToStackLayout(object sender, EventArgs e)
        {   
            await Navigation.PushAsync(new StackLayout());
        }
    }
}