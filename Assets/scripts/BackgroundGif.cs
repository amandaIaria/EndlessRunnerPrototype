using UnityEngine;
using System.Collections;

public class BackgroundGif : MonoBehaviour {

	private Texture2D[] frames; 
	private float framesPerSecond = 10;
	
	void Update () { 
		float index = Time.time * framesPerSecond; 
		index = index % frames.Length; 
		int indexInt = (int) index;
		renderer.material.mainTexture = frames[indexInt]; 
	}
}
