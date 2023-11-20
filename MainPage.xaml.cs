namespace BorderClippingBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindableLayout.SetItemsSource(layout, new[] { 0, 1, 2, 4, 8, 16, 32 });
        }

    }
}
