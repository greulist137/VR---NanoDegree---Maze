using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door

	public GameObject KeyPoofPrefab;
	public GameObject newDoor;
	bool keyCollected = false;

	public AudioClip Key_Pickup;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{

        // Call the Unlock() method on the Door
		Door other = (Door) newDoor.GetComponent(typeof(Door));
		other.Unlock();

		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		GameObject newPrefab1 = (GameObject) Object.Instantiate (KeyPoofPrefab, new Vector3 (20, 2, 90), Quaternion.identity);

		AudioSource.PlayClipAtPoint (Key_Pickup, transform.position);

		keyCollected = true;

		// Destroy the key. Check the Unity documentation on how to use Destroy
		DestroyObject (KeyPoofPrefab);

		DestroyObject (newPrefab1);

    }

}
