using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TriggerForNextGameSpace : MonoBehaviour {
	
	//for testing purposes
	public Text testingText1;
	
	public GameObject gameSpace1;
	public GameObject gameSpace2;
	public GameObject gameSpace3;
	private bool start = false;
	
	void Awake(){
		//this will be for the one after the start.
		//but for the moment I'll just work on the trigger events
		//float randomNumber = Random.Range (0f,1f);
		//CreatGameObject(randomNumber);
		start = true;
	}

	
	void OnTriggerEnter2D(Collider2D col){
		ChooseNextGameObject(col);
	}
	
	void ChooseNextGameObject(Collider2D col){
		//isBreakable = (this.tag == "Breakable");
		if(col.tag == "Player"){
			float randomNumber = Random.Range (0f,1f);
			CreatGameObject(randomNumber);
		}
	}
	// TODO : what is Quaternion.identity
	
	void CreatGameObject(float randomNumber){ 
		Vector3 startingCordsForGameSpaceObject;
		//if(!start){
		//	start = true;
			//startingCordsForGameSpaceObject = new Vector3(16f,0f,0f);
		//}
		//else{
			startingCordsForGameSpaceObject = new Vector3(30f,0f,0f);
		//}
		print (randomNumber);
		if(randomNumber <= 0.33f){
			print ( "first object ");
			GameObject gameSpaceClone1 = (GameObject) Instantiate(gameSpace1, startingCordsForGameSpaceObject, Quaternion.identity);
		}
		else if(randomNumber >= 0.34f && randomNumber <= 0.67f){
			print ( "second object ");
			GameObject gameSpaceClone2 = (GameObject) Instantiate(gameSpace2, startingCordsForGameSpaceObject, Quaternion.identity);
		}
		else{
			print ( "third object ");
			GameObject gameSpaceClone3 = (GameObject) Instantiate(gameSpace3, startingCordsForGameSpaceObject, Quaternion.identity);
		}
	}
}
