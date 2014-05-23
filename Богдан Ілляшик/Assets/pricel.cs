using UnityEngine;
using System.Collections;

public class pricel : MonoBehaviour {

	public Texture2D tex;
	void OnGUI()
	{
		GUI.Label (new Rect(((Screen.width)/2+30) - (tex.width), ((Screen.height)/2+30) - (tex.height), (tex.width), (tex.height)), tex);
	}
}
