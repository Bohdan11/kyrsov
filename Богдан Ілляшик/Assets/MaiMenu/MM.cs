using UnityEngine;
using System.Collections;

public class MM : MonoBehaviour {
	private int _window = 0;

	void OnGUI(){
				if (_window == 0) {
						GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 180), "Main menu");
		
						if (GUI.Button (new Rect (Screen.width / 2 - 90, Screen.height / 2 - 80, 180, 30), "Play")) {
								Application.LoadLevel (1);
						}
						if (GUI.Button (new Rect (Screen.width / 2 - 90, Screen.height / 2 - 40, 180, 30), "Internet")) {
								Application.OpenURL ("www.google.com");
						}
						if (GUI.Button (new Rect (Screen.width / 2 - 90, Screen.height / 2 + 0, 180, 30), "Help")) {
								_window = 2;
						}
						if (GUI.Button (new Rect (Screen.width / 2 - 90, Screen.height / 2 + 40, 180, 30), "Exit")) {
								Application.Quit ();
						}
				}
	
				if (_window == 2) {
						GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 180), "Help");
						GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 80, 180, 140), "ESC - Пауза під час гри");
							if (GUI.Button ( new Rect (Screen.width / 2 - 90, Screen.height / 2 + 40, 180, 30), "Back") || Input.GetKey ("escape"))
							{
								_window = 0;
							}
				
				}
		}
}
