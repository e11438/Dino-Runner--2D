using UnityEngine;
using System.Collections;

public class TouchControlls : MonoBehaviour {

	private PlayerController player;

	private PauseMenu pauseMenu;

	//public bool 

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		pauseMenu = FindObjectOfType<PauseMenu> ();
	}
	
	public void Jump(){
		player.Jump ();
	}

	public void Pause(){
		pauseMenu.PauseUnpause ();
	} 
}
