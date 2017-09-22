using UnityEngine;
using System.Collections;

public class DestroyCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(col.tag == "background" ){
			Destroy(col.gameObject);
		}
		else{
			Destroy(col.transform.parent.gameObject);
		}
	}
}
