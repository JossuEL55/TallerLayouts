
namespace TallerLayouts.Pages
{
    public partial class FlexLayout : ContentPage
    {
        public FlexLayout()
        {
            InitializeComponent();
        }

        private async void OnImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayout());
        }
    }
}
