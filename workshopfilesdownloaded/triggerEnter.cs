using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class triggerEnter : MonoBehaviour {


	public Collider target;
	private int numberOfHits = 0; // Note how declaring the “numberOfHits” variable as private  won’t make it show up in the Inspector
	public AudioClip beep;
	AudioSource audioSource;




	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	// This script is only triggered upon entering the trigger zone – “OnTriggerEnter” – so we don’t need 
	// to worry about multiple counts per visit in the trigger zone.
	void OnTriggerEnter(Collider cubeTrigger) {
		if (cubeTrigger == target)  
		{
			numberOfHits = numberOfHits + 1;
			audioSource.PlayOneShot(beep, 0.7F);
			print("Bumped: " + numberOfHits + " times!");
		}
	}

	//If you would like to render the trigger zone invisible just uncheck the game object’s 
	//“Mesh Renderer” property in the Inspector, resp. set the Mesh Renderer to "none".


	
	// Update is called once per frame
	void Update () {
		
	}
}
