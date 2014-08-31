using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class SocialPost {

	// ----------------------------------------
	// twitter

	#if UNITY_ANDROID
	private static AndroidJavaObject unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
	private static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
	static void android_share(string package_name, string text) {
		AndroidJavaObject intent = new AndroidJavaObject( "android.content.Intent" );
		intent.Call<AndroidJavaObject>( "setPackage", package_name );
		intent.Call<AndroidJavaObject>( "setType", "text/plain" );
		intent.Call<AndroidJavaObject>( "putExtra", "android.intent.extra.TEXT" , text );
		currentActivity.Call( "startActivity", intent.CallStatic<AndroidJavaObject>("createChooser", intent, "Select application") );
		intent.Dispose();
	}
	#endif

	[DllImport("__Internal")]
	private static extern void twitter_ (string s);
	public static void twitter (string s) {
		#if UNITY_ANDROID && !UNITY_EDITOR
			android_share( "com.twitter.android", s );
		#else
		if (Application.platform != RuntimePlatform.OSXEditor) {
			twitter_(s);
		}
		#endif
	}

	// ----------------------------------------
	// facebook

	[DllImport("__Internal")]
	private static extern void facebook_ (string s);
	public static void facebook (string s) {
		#if UNITY_ANDROID && !UNITY_EDITOR
			android_share( "com.facebook.katana", s );
		#else
		if (Application.platform != RuntimePlatform.OSXEditor) {
			facebook_(s);
		}
		#endif
	}

}
