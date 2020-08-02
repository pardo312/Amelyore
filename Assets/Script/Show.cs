using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
	public bool show = false;
	private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        if(show)
		{
			timer ++;
			if(timer > 100) 
			{
				show = false;
				Destroy(this);
				
			}
		}
    }
}
