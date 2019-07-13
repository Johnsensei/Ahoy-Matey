using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

/*	private NetworkManager networkManager;

	// Use this for initialization
	void Start () {
		networkManager = GetComponent<NetworkManager> ();
	}
*/

	public void MyStartHost (){
		//networkManager.
		StartHost ();
		Debug.Log ("Starting host at " + Time.timeSinceLevelLoad);
	}


	public override void OnStartHost(){
		Debug.Log ("Started host at " + Time.timeSinceLevelLoad);
	}
		

	public override void OnStartClient (NetworkClient myClient){
		Debug.Log ("Client Start requested at " + Time.timeSinceLevelLoad);
		InvokeRepeating ("PrintDots", 0f, 1f);
	}

	public override void OnClientConnect (NetworkConnection conn){
		Debug.Log (Time.timeSinceLevelLoad + " Client is connected to IP: " + conn.address);
		CancelInvoke ();
	}

	void PrintDots (){
		Debug.Log (".");
	}



	// Update is called once per frame
	void Update () {
		
	}
}
