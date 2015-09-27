using UnityEngine;
using System.Collections;

public class TouchControllsForPuzzel : MonoBehaviour {
	private PauseMenu pauseMenu;

	public string failedLevel;
	public string nextLevel;

	
	public bool redClicked;
	public bool blueClicked;
	public bool greenClicked;
	
	// Use this for initialization
	void Start () {
		//player = FindObjectOfType<PlayerController> ();
		pauseMenu = FindObjectOfType<PauseMenu> ();
		redClicked = false;
		blueClicked = false;
		greenClicked = false;
	}
	

	
	public void Pause(){
		pauseMenu.PauseUnpause ();
	} 

	public void ClickRed(){
		Application.LoadLevel (failedLevel);

	}
	public void ClickBlue(){
		Application.LoadLevel (failedLevel);
		
	}
	public void ClickGreen(){
		
		Application.LoadLevel (nextLevel);
	}
}
