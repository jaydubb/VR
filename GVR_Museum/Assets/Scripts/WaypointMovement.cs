using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour {

	public GameObject player;
	public GameObject guideUI1, guideUI2;


	public bool teleport;

	private float heightAboveWaypoint = 0.7f;


	public void Move (GameObject waypoint) {
        guideUI1.SetActive(false);
        guideUI2.SetActive(false);
		
		if (!teleport) {
			iTween.MoveTo (player,
				iTween.Hash (
					"position", new Vector3 (waypoint.transform.position.x, waypoint.transform.position.y + heightAboveWaypoint, waypoint.transform.position.z),
					"time", .3f,
					"easetype", "linear"
				)
			);
		} else {
			player.transform.position = new Vector3 (waypoint.transform.position.x, waypoint.transform.position.y + heightAboveWaypoint, waypoint.transform.position.z);
		}
	}
}
