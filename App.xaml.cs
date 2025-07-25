
namespace DLogBook
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzA0NjczMEAzMjM0MmUzMDJlMzBkSFdKSzVvSnh0bmc0ZXdhOEpZaERlRlg4SGNQcFJKMk9iNm0zaWY0aGY0PQ ==");//Added by Amish as per requirement
            
            MainPage = new MainPage();
        }
    }
}
