using UnityEngine;
using System.Runtime.InteropServices;
public class SocialPost {
    [DllImport("__Internal")]
	private static extern void twitter_ (string s);
	public static void twitter (string s) {
		if (Application.platform != RuntimePlatform.OSXEditor) {
			twitter_(s);
		}
	}
	[DllImport("__Internal")]
	private static extern void facebook_ (string s);
	public static void facebook (string s) {
		if (Application.platform != RuntimePlatform.OSXEditor) {
			facebook_(s);
		}
	}
}
