using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject CoinPoofPrefab;
	public AudioClip Coin_Pickup;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		GameObject newPrefab1 = (GameObject) Object.Instantiate (CoinPoofPrefab, new Vector3 (2, 1, 85), Quaternion.identity);
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

		AudioSource.PlayClipAtPoint (Coin_Pickup, transform.position);

		DestroyObject (CoinPoofPrefab);
		DestroyObject (newPrefab1);
    }

}
