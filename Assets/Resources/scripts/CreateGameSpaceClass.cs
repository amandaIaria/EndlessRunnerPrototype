using UnityEngine;
using System.Collections;

public class CreateGameSpaceClass : MonoBehaviour {
	
	public GameObject gameSpace1;
	public GameObject gameSpace2;
	public GameObject gameSpace3;
	
	private bool hasStarted = false;
	
	void Awake(){
		if(!hasStarted){
			float randomNumber = Random.Range (0.01f,1f);
			CreatGameObject(randomNumber);
			hasStarted = true;
		}
	}
	
	
	 void CreatGameObject(float randomNumber){ 
		Vector3 startingCordsForGameSpaceObject;
		if(!hasStarted){
			startingCordsForGameSpaceObject = new Vector3(16f,0f,0f);
		}
		else{
			startingCordsForGameSpaceObject = new Vector3(30f,0f,0f);
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
	}
}
