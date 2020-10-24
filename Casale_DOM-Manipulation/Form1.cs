using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casale_DOM_Manipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.webBrowser1.Navigate("c:\\temp\\example.html");
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);



        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Page";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Info";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[1];
            htmlElement.InnerText = "My UFO Pictures";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[2];
            htmlElement.InnerText = "";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #a000a0;";

            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "Report your UFO sightings here: <a href='http://www.nuforc.org'>Kitties!</a>";
            htmlElement.Style += "color: #00ff00; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #a44";

            htmlElement = htmlElementCollection[1];
            htmlElement.InnerText = "";

            HtmlElement htmlElement1 = webBrowser.Document.CreateElement("img");
            htmlElement1.SetAttribute("src", "https://images.axios.com/40yKmjksUxd94lm5FsUDW9g_Plk=/0x0:6850x3853/1920x1080/2019/04/25/1556227241167.jpg");

            htmlElement1.InnerHtml = "&copy;2020 Lauren Casale";
            webBrowser.Document.Body.AppendChild(htmlElement1);

        }

    }

}
