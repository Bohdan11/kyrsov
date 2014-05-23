using UnityEngine;
using System.Collections;

public class PauseTutor : MonoBehaviour {
	private bool pause;
	private int selGridInt;
	private int screenWidth;
	private int screenHeight;
	private bool fullScreen;
	private bool screenResolution;
	private string[] selStrings = new string[] {"Graphics","Controls","Audio"};
	void OnGUI()
	{
		if(pause==true)
		{
			GUI.BeginGroup(new Rect(50,25,1081,727));
			if(GUI.Button(new Rect(1050,5,20,20),"X"))
			{
				Exit();
			}
			if(GUI.Button(new Rect(950,670,100,20),"Exit"))
			{
				Application.Quit();
			}
			selGridInt = GUI.SelectionGrid(new Rect(5, 12, 100*3,23), selGridInt, selStrings, 3);
			//Graphics
			if(selGridInt==0)
			{
				if(GUI.Button(new Rect(),"Save"))
				{
					Screen.SetResolution(screenWidth, screenWidth,fullScreen);
				}
				if(GUI.Button(new Rect(92,70,90,23), screenWidth+"x"+screenHeight))
				{
					screenResolution = !screenResolution;
				}
				if(screenResolution==true)
				{
					if(GUI.Button(new Rect(92,93,90,23), "800x600"))
					{
						screenWidth = 800;
						screenHeight = 600;
						screenResolution = false;
					}
					if(GUI.Button(new Rect(92,116,90,23), "1280x1024"))
					{
						screenWidth = 1280;
						screenHeight = 1024;
						screenResolution = false;
					}
					if(GUI.Button(new Rect(92,139,90,23), "1680x1080"))
					{
						screenWidth = 1680;
						screenHeight = 1080;
						screenResolution = false;
					}


				}
				GUI.enabled = !screenResolution;
				bool NewFullScreen= GUI.Toggle(new Rect(92,110,25,25), fullScreen, "");
				if(NewFullScreen!=fullScreen)
				{
					fullScreen = NewFullScreen;
				}

				GUI.enabled = true;
			
			}
			//Control
			if (selGridInt==1)
			{
				
			}
			//Audio
			if (selGridInt==2)
			{

			}


			GUI.EndGroup();
		}
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			screenWidth = Screen.width;
			screenHeight= Screen.height;
			pause = true;
		}
	}
	void Exit()
	{
		pause = false;
		screenResolution = false; 
	}
}
