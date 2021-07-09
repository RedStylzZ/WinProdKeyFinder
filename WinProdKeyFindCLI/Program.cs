using System;
using WinProdKeyFind;
using System.Windows.Forms;

namespace WinProdKeyFindCLI
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string key = KeyDecoder.GetWindowsProductKeyFromRegistry();
            Console.WriteLine("Key: " + key);
            Console.WriteLine("Copying to clipboard...");
            copyToClipboard(key);
        }

        static private void copyToClipboard(string key)
        {
            // set selection (select all)
            tbWindowsProductKey.SelectionStart = 0;
            tbWindowsProductKey.SelectionLength = tbWindowsProductKey.Text.Length;
            // copy selection to the clipboard
            tbWindowsProductKey.Copy();


        }
    }
}
