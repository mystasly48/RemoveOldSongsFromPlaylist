using System.Windows.Forms;

namespace RemoveOldSongsFromPlaylist {
  public partial class Browser : Form {
    public Browser(string url) {
      InitializeComponent();
      webBrowser1.ScriptErrorsSuppressed = true;
      webBrowser1.Navigate(url);
    }

    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
      Close();
    }
  }
}
