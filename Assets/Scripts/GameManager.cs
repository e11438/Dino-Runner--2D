using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static string currentLevel;

	public void setCurrentLevel(string level){
		currentLevel = level;
	}
}
