using UnityEngine;
using System.Collections;

public class SwordSwing : MonoBehaviour 
{
	Animator a;

	float gravity = 0.0f;
	float sensitivity = 0.1f;

	void Start () 
	{
		a = GetComponent<Animator>();
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	void Update () 
	{
		// code to trigger Swing method on relative movement downards

		Vector3 dir = Vector3.zero;

		dir.x = -Input.acceleration.y;
		dir.z = Input.acceleration.x;

		gravity = ((1.0f - sensitivity) * gravity) + (sensitivity * Input.acceleration.x);

		if(Input.acceleration.x - gravity > 0.5)
        {
			Swing();
        }


	}

	void Swing()
	{
		a.Play ("Slash", -1, 0.0f);
	}
}
