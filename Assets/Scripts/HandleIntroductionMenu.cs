using UnityEngine;
using System.Collections;

public class HandleIntroductionMenu : MonoBehaviour {

	public bool started;
	
	public GameObject pauseMenuCanvas;

	// Use this for initialization
	void Start () {

		started = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (started) {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale=1f;
		} else {
			pauseMenuCanvas.SetActive(true);
			Time.timeScale=0f;
		}
	
	}

	public void GameStart(){
		started=true;
	}
}
