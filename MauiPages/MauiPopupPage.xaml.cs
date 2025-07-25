
using Microsoft.Maui.Devices;

namespace DLogBook.MauiPages;

public partial class MauiPopupPage
{
	public MauiPopupPage()
	{
		InitializeComponent();
	}

    private void scanner_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {

        try
        {
            scanner.IsDetecting = false;
            scanner.IsEnabled = true;
            if (e.Results != null && e.Results.Length > 0)
            {
                Close(e.Results[0].Value);
            }
            else
            {
                Console.WriteLine("No barcode detected.");
            }
            //Close(e.Results[0].Value);
        }
        catch (Exception ex) {
            Console.WriteLine("Exception in scanner_BarcodesDetected: " + ex.Message);
        }
        
    }
}