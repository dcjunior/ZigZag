using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject CurrentTile;
	public GameObject[] tilePrefab;
	private static Spawn instance;

	public static Spawn Instance {
		get {
			if (instance == null) {
				instance = GameObject.FindObjectOfType<Spawn> ();
			}
			return instance;
		}
	}


	// Use this for initialization
	void Start () {
		for(int i =0;i<5;i++)
		SpawnTiles ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnTiles(){
		int ran = Random.Range (0, 2);
		CurrentTile = (GameObject)Instantiate (tilePrefab[ran], CurrentTile.transform.GetChild (0).transform.GetChild(ran).position,Quaternion.identity);

	
	}

}
