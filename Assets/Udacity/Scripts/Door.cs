using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	bool locked = true;
	bool opening = false;

	public float speed = 2f;

	public AudioClip Door_Locked;
	public AudioClip Door_Opened;


    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		if (opening == true) {
			AudioSource.PlayClipAtPoint (Door_Opened, transform.position);
			transform.Translate (0, speed * Time.deltaTime, 0);
		} 
		else {
			AudioSource.PlayClipAtPoint (Door_Locked, transform.position);
		}


    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
		if (locked == false) {
			opening = true;
			Update ();
		} 




    }

    public void Unlock()
    {
		locked = false;
    }
}
