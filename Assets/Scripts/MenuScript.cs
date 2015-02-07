using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public void LaunchGame()
	{
		Application.LoadLevel("RocketMouse");
	}
	public void Start(){

		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
}
