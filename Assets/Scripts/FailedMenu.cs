using UnityEngine;
using System.Collections;

public class FailedMenu : MonoBehaviour {

	public string startLevel;
	//public string levelSelect;
	
	
	public void StartAgain(){
		Application.LoadLevel (startLevel);
	}
	
	public void InappPurchase(){
		//Application.LoadLevel (levelSelect);
	}
	

}
