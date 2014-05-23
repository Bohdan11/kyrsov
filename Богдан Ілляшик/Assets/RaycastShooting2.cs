using UnityEngine;
using System.Collections;

public class RaycastShooting2 : MonoBehaviour {
	public Transform camera1;
	public Transform metalHit;
	public Transform MetalSparks;
	private RaycastHit Hit;
	public Transform MuzzleFlash;
	public int BulletHoleLifeTime=15;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Vector3 Direction = camera1.TransformDirection(Vector3.forward);
			MuzzleFlash.particleEmitter.emit = true;
			if(Physics.Raycast(camera1.position, Direction, out Hit, 10000f))
			{
				Quaternion HitRotation = Quaternion.FromToRotation(Vector3.up, Hit.normal);
				if(Hit.transform.rigidbody)
				{
					Hit.transform.rigidbody.AddForceAtPosition(Direction*1000, Hit.point);
				}
				if(Hit.collider.material.staticFriction==0.2f)
			    {
					Transform metalhitGO = Instantiate(metalHit,Hit.point+(Hit.normal*0.001f),HitRotation) as Transform;
					metalhitGO.transform.parent = Hit.transform;
					Destroy((metalhitGO as Transform).gameObject, BulletHoleLifeTime);
					//Sparks
					Instantiate(MetalSparks,Hit.point+(Hit.normal*0.01f),HitRotation);

				}
			}
		}
		else
		{
			MuzzleFlash.particleEmitter.emit = false;
		}
	}
}