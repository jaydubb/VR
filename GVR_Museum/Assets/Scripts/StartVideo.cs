using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartVideo : MonoBehaviour {

	public GameObject playButton;
	public VideoPlayer vidScreen;

	void Awake () {
		vidScreen = vidScreen.GetComponent<VideoPlayer> ();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayPause () {
		if (vidScreen.isPlaying) {
	        playButton.SetActive(true);
			vidScreen.Pause();
		} else {
	        playButton.SetActive(false);
			vidScreen.Play();
		}
	}
}
