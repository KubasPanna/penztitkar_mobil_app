using penztitkar_kubaspanna.Views;

namespace penztitkar_kubaspanna
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("edittransaction", typeof(EditTransactionPage));
            Routing.RegisterRoute("statistics", typeof(StatisticsPage));
            Routing.RegisterRoute("imagepreview", typeof(ImagePreviewPage));

        }
    }
}
