using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

	public int maxPlayerHealth;

	public static int playerHealth;
	public bool isDead;

	Text text;
	private  LevelManager levelManager;
	// Use this for initialization
	void Start () {
		isDead = false;
		text = GetComponent<Text> ();
		playerHealth = maxPlayerHealth;
		levelManager = FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth <= 0&& !isDead) {
			levelManager.RespawnPlayerFromBegining();
			isDead=true;
		}
		text.text = playerHealth + "";
	
	}

	public static void HurtPlayer(int damageToGive){
		playerHealth -= damageToGive;

	}

	public void FullHealth(){
		playerHealth = maxPlayerHealth;
	}
}
