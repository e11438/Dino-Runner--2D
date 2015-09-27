using UnityEngine;
using System.Collections;

public class LevelselectScript : MonoBehaviour {

	public string level1;
	public string level2;
	public string mainMenu;

	// Use this for initialization
	public void Level1(){
		Application.LoadLevel (level1);
	}
	public void Level2(){
		Application.LoadLevel (level2);
	}

	public void Back(){
		Application.LoadLevel (mainMenu);
	}

}
