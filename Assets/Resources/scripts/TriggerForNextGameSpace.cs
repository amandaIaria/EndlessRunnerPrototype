using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TriggerForNextGameSpace : MonoBehaviour {
	
	private bool hasStarted = true;
	
	private GameObject gameSpace1;
	private GameObject gameSpace2;
	private GameObject gameSpace3;
	private GameObject background;
	
	void Start(){
		gameSpace1 = (GameObject)Resources.Load("prefabs/GameSpace1") as GameObject ;
		gameSpace2 = (GameObject)Resources.Load("prefabs/GameSpace2", typeof(GameObject));
		gameSpace3 = (GameObject)Resources.Load("prefabs/GameSpace3", typeof(GameObject));
		background = (GameObject)Resources.Load("prefabs/CityBackground", typeof(GameObject));
		
	}
	
	void OnTriggerEnter2D(Collider2D col){
		ChooseNextGameObject(col);
	}
	
	void ChooseNextGameObject(Collider2D col){
		if(col.tag == "Player" && hasStarted){
			float randomNumber = Random.Range (0.01f,1f);
			CreatGameObject(randomNumber);
		}
	}
	void CreatGameObject(float randomNumber){ 
		Vector3 startingCordsForGameSpaceObject;
		Vector3 startingCordsForBG = new Vector3(32f,0f,5f);
		if(!hasStarted){
			startingCordsForGameSpaceObject = new Vector3(16f,0f,0f);
		}
		else{
			startingCordsForGameSpaceObject = new Vector3(32f,0f,0f);
		}
		if(randomNumber <= 0.33f){
			GameObject gameSpaceClone1 = (GameObject) Instantiate(gameSpace1, startingCordsForGameSpaceObject, Quaternion.identity);
		}
		else if(randomNumber >= 0.34f && randomNumber <= 0.67f){
			GameObject gameSpaceClone2 = (GameObject) Instantiate(gameSpace2, startingCordsForGameSpaceObject, Quaternion.identity);
		}
		else{
			GameObject gameSpaceClone3 = (GameObject) Instantiate(gameSpace3, startingCordsForGameSpaceObject, Quaternion.identity);
		}
		GameObject BackgroundClone = (GameObject) Instantiate(background, startingCordsForBG, Quaternion.identity);
	}
	
}
