namespace RestaurantMaster
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Navigate to the Reservations Page
        private async void OnManageReservationsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReservationsPage());
        }

        // Navigate to the Orders & Menu Page
        private async void OnManageOrdersMenuClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrdersMenuPage());
        }
    }
}
