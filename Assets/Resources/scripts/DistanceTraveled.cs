using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DistanceTraveled : MonoBehaviour {

	public Text text;
	public GameObject player;
	
	private float currentTime;
	private int distance;

	void Update () {
		countingWorldSpaceToFeet();
	}
	
	void countingWorldSpaceToFeet(){
		currentTime = Time.timeSinceLevelLoad *4;
		distance = (int)Mathf.Round(currentTime);
		text.text = "Distance: " + distance.ToString() + "ft";
	}
}
