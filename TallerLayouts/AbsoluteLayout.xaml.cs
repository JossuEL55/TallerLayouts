namespace TallerLayouts.Pages
{
    public partial class AbsoluteLayout : ContentPage
    {
        public AbsoluteLayout()
        {
            InitializeComponent();
        }

        private async void OnNavigateToGridLayout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayout());
        }
    }
}