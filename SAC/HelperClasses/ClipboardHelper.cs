using System;
using System.Windows.Forms;

namespace SAC.HelperClasses
{
    internal class ClipboardHelper
    {
        public static void OpenBrowser()
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/Kinggg.NNT/");
                Clipboard.SetText("https://www.facebook.com/Kinggg.NNT/");
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Failed. Error: {ex.Message}", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clipboard.SetText("https://www.facebook.com/Kinggg.NNT/");
                MessageBox.Show($"Cannot Open Browser. My Infomation copied to clipboard. Please, paste to your browser and go to", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}