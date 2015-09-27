using UnityEngine;
using System.Collections;

public class LevelManagerForBallPuzzel : MonoBehaviour {
	private float height_blue;
	private float height_red;
	private float height_green;

	public static string max;
	// Use this for initialization
	void Start () {

		height_red = RedBallBouncer.maxHeight;
		height_green = GreenBallBouncer.maxHeight;
		height_blue = BlueBallBouncer.maxHeight;

		if (height_red > height_blue) {
			if(height_red>height_green){
				max="red";
			}else{
				max="green";
			}

		} else {

			if(height_blue>height_green){
				max="blue";
			}else{
				max="green";
			}

		}
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("sdsdsd"+max);
	
	}
}
