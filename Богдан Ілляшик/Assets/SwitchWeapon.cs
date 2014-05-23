using UnityEngine;
using System.Collections;

public class SwitchWeapon : MonoBehaviour {
	public GameObject gun1;
	public GameObject gun2;
	public GameObject gun3;
	private int curWeapon;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetAxis("Mouse ScrollWheel")<0)
		{
			curWeapon -= 1;
			Switch();
		}
		if(Input.GetAxis("Mouse ScrollWheel")>0)
		{
			curWeapon += 1;
			Switch();
		}
		if(curWeapon>3)
		{
			curWeapon = 1;
			Switch();
		}
		if(curWeapon<1)
		{
			curWeapon = 3;
			Switch();
		}
		if(Input.GetKeyDown("1"))
		{
			curWeapon = 1;
			Switch();
		}
		if(Input.GetKeyDown("2"))
		{
			curWeapon = 2;
			Switch();
		}
		if(Input.GetKeyDown("3"))
		{
			curWeapon = 3;
			Switch();
		}
	}
	void Null()
	{
		gun1.SetActive(false);
		gun2.SetActive(false);
		gun3.SetActive(false);
	}
	void Switch()
	{
		if(curWeapon == 1)
		{
			Null();
			gun1.SetActive(true);
		}
		if(curWeapon == 2)
		{
			Null();
			gun2.SetActive(true);
		}
		if(curWeapon == 3)
		{
			Null();
			gun3.SetActive(true);
		}
	}
}