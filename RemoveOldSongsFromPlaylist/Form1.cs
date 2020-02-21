using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Threading;

namespace RemoveOldSongsFromPlaylist {
  public partial class Form1 : Form {
    SpotifyWebAPI spotify;
    PrivateProfile profile;
    Dispatcher dispatcher;
    List<SimplePlaylist> myPlaylists;

    public Form1() {
      InitializeComponent();
      SpotifyAuth();
    }

    private async void OnAuthReceived(object sender, AuthorizationCode payload) {
      AuthorizationCodeAuth auth = (AuthorizationCodeAuth)sender;
      auth.Stop();
      Token token;
      token = await auth.ExchangeCode(payload.Code);
      spotify = new SpotifyWebAPI() {
        TokenType = token.TokenType,
        AccessToken = token.AccessToken
      };
    }

    private void SpotifyAuth() {
      AuthorizationCodeAuth auth = new AuthorizationCodeAuth(
        Secret.ClientId,
        Secret.ClientSecret,
        "http://localhost:4002",
        "http://localhost:4002",
        // See https://developer.spotify.com/documentation/general/guides/scopes/
        Scope.PlaylistModifyPrivate // remove tracks from own private playlist
        | Scope.PlaylistModifyPublic // remove tracks from own public playlist
        | Scope.PlaylistReadCollaborative
        | Scope.PlaylistReadPrivate
      );
      auth.AuthReceived += OnAuthReceived;
      auth.Start();
      string url = auth.GetUri();
      Debug.WriteLine("Auth: " + url);
      Browser browser = new Browser(url);
      browser.ShowDialog();
      profile = spotify.GetPrivateProfile();
    }

    private void Form1_Load(object sender, EventArgs e) {
      dispatcher = Dispatcher.CurrentDispatcher;
      LoadPlaylists();
    }

    private async void LoadPlaylists() {
      var playlists = await spotify.GetUserPlaylistsAsync(profile.Id, 50, 0);
      myPlaylists = playlists.Items;
      int offset = 50;
      while (playlists.HasNextPage()) {
        playlists = await spotify.GetUserPlaylistsAsync(profile.Id, 50, offset);
        offset += 50;
        myPlaylists.AddRange(playlists.Items);
      }
      myPlaylists = myPlaylists.Where(x => x.Owner.Id == profile.Id).ToList();

      await dispatcher.BeginInvoke(new Action(() => {
        foreach (var s in myPlaylists) {
          listBox1.Items.Add(s);
        }
        listBox1.ValueMember = "Id";
        listBox1.DisplayMember = "Name";
      }));
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
      SimplePlaylist item = (SimplePlaylist)listBox1.SelectedItem;
      labelPlaylistName.Text = item.Name;
      labelPlaylistOwner.Text = item.Owner.DisplayName;
      labelPlaylistTotal.Text = item.Tracks.Total.ToString();

      listBox2.Items.Clear();
      var playlists = spotify.GetPlaylistTracks(item.Id);
      while (true) {
        foreach (var s in playlists.Items) {
          listBox2.Items.Add(s.Track);
        }
        if (playlists.HasNextPage()) {
          playlists = spotify.GetPlaylistTracks(item.Id, offset:playlists.Offset+100);
        } else {
          break;
        }
      }
      listBox2.ValueMember = "Id";
      listBox2.DisplayMember = "Name";
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {
      FullTrack item = (FullTrack)listBox2.SelectedItem;
      labelTrackName.Text = item.Name;
      labelTrackArtist.Text = string.Join(", ", item.Artists.Select(x => x.Name));
      labelTrackAlbum.Text = item.Album.Name;
      pictureBox1.ImageLocation = item.Album.Images.First().Url;
    }
  }
}
