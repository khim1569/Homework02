using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Homework02 : MonoBehaviour {
	public Button Putskill;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void notUpdate () {
		StartCoroutine (Skill ());
	
	}

	IEnumerator Skill(){
		Putskill.interactable = false;
		yield return new WaitForSeconds (3f);
		Putskill.interactable = true;
	}
}
