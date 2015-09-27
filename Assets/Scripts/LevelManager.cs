using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject firstCheckPoint;
	public GameObject currentCheckPoint;
	public GameObject deathParticle;
	public GameObject respawnParticle;

	public float respawnDelay;
	public int pointPenaltyOnDeath;

	//private float gravity;
	private PlayerController player;
	new public CameraController camera;
	public HealthManager healtManager;

	// Use this for initialization
	void Start () {
		firstCheckPoint = currentCheckPoint;
		player = FindObjectOfType<PlayerController> ();
		camera = FindObjectOfType<CameraController> ();
		healtManager = FindObjectOfType<HealthManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer(){

		StartCoroutine ("RespawnPlayerCo");
	} 

	public void RespawnPlayerFromBegining(){
		
		StartCoroutine ("RespawnPlayerFromBeginingCo");
	} 

	public IEnumerator RespawnPlayerCo(){
		//gravity = player.rigidbody2D.gravityScale;
		Instantiate (deathParticle,player.transform.position,player.transform.rotation);

		player.enabled = false;
		player.renderer.enabled = false;
		camera.isFollowing =false;
		///player.rigidbody2D.gravityScale = 0f;
		ScoreManager.AddPoints (-pointPenaltyOnDeath);
		Debug.Log ("Player respawned");
		yield return new WaitForSeconds (respawnDelay);
		player.enabled = true;
		player.renderer.enabled = true;
		camera.isFollowing =true;
		//player.rigidbody2D.gravityScale = gravity;
		player.transform.position = currentCheckPoint.transform.position;
		Instantiate (respawnParticle,currentCheckPoint.transform.position,currentCheckPoint.transform.rotation);

	}

	public IEnumerator RespawnPlayerFromBeginingCo(){
		//gravity = player.rigidbody2D.gravityScale;
		Instantiate (deathParticle,player.transform.position,player.transform.rotation);
		
		player.enabled = false;
		player.renderer.enabled = false;
		camera.isFollowing =false;
		///player.rigidbody2D.gravityScale = 0f;
		ScoreManager.AddPoints (-pointPenaltyOnDeath);
		Debug.Log ("Player respawned");
		yield return new WaitForSeconds (respawnDelay);
		player.enabled = true;
		player.renderer.enabled = true;
		camera.isFollowing =true;
		healtManager.FullHealth ();
		healtManager.isDead = false;
		//player.rigidbody2D.gravityScale = gravity;
		player.transform.position = firstCheckPoint.transform.position;
		Instantiate (respawnParticle,firstCheckPoint.transform.position,firstCheckPoint.transform.rotation);
		
	}
}
