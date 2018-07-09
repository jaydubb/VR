using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUp : MonoBehaviour {

	public GameObject playerCam, startUI, guide1, guide2, startingWaypoint;
	private float heightAboveWaypoint = 0.7f;


	// Use this for initialization
	void Start () {
		
	}

    public void StartTour()
    {
        // Disable the start UI.
        startUI.SetActive(false);
        guide1.SetActive(true);
        guide2.SetActive(true);
		iTween.MoveTo (playerCam,
			iTween.Hash (
				"position", new Vector3 (startingWaypoint.transform.position.x, startingWaypoint.transform.position.y + heightAboveWaypoint, startingWaypoint.transform.position.z),
				"time", .3f,
				"easetype", "linear"
			)
		);

    }

	// Update is called once per frame
	void Update () {
		
	}
}
