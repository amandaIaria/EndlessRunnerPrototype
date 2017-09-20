using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	//private Player player;
	private Vector3 startingPlayerPos;
	
	void Start(){
		startingPlayerPos = this.transform.position;
		//print ("startingPlayerPos "+startingPlayerPos );
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			Jump(this.transform.position);
		}
	}
	
	void Jump(Vector3 pos){
		float amountInAir = 2f;
		Vector3 jumpingChar = new Vector3(0.5f, (this.transform.position.y + amountInAir), 0);
		if(pos.y <= startingPlayerPos.y ){
			//print ("how many times");
			this.transform.position = jumpingChar;
		}
		//print ("new pos" + this.transform.position);
		//Starting position of the player
		//add to the y position of the player
		

	}
}
