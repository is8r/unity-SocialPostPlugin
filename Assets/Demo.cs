//C#
using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour {

	void OnGUI () {

		int screenWidth = 320;
		int screenHeight = 568;
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
		
		GUI.Box(new Rect(10,10,100,70), "");
		if(GUI.Button(new Rect(20,20,80,20), "Twitter")) {
			SocialPost.twitter("Post Message http://12px.com #unity");
		}
		
		if(GUI.Button(new Rect(20,50,80,20), "Facebook")) {
			SocialPost.facebook("Post Message http://12px.com #unity");
		}
	}
	
}
