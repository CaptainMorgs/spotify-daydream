using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models;

public class PlaylistScript : MonoBehaviour {

	private string playlistName, playlistURI;
	private SimplePlaylist simplePlaylsit;
	private GameObject spotifyManager;
	private Spotify script;
	private PlaybackContext playbackContext;
    public GameObject  playlistNameObject;
    private UnityEngine.UI.Text playlistNameText;	

	// Use this for initialization
	void Start () {
		spotifyManager = GameObject.Find ("SpotifyManager");
		script = spotifyManager.GetComponent<Spotify>();
        playlistNameText = playlistNameObject.GetComponent<UnityEngine.UI.Text>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setPlaylistURI (string playlistURI) {
		this.playlistURI = playlistURI;
        
	}

	public void setPlaylistName (string playlistName) {
		this.playlistName = playlistName;
        playlistNameText.text = playlistName;

    }

	public void playPlaylist() {
		script.playPlaylist (playlistURI);
	}
}
