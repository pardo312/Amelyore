using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUpDown : MonoBehaviour
{
   
	private float incr = 0f;
	private bool top = true;
    // Update is called once per frame
    void FixedUpdate()
    {
		
		if(incr >10)
		{
			top = true;
		}
		else if(incr < -10)
		{
			top = false;
		}
		if(top)
		{
			incr--;
		}
		else
		{
			incr++;
		}
        transform.position = new Vector3(transform.position.x  ,transform.position.y + (incr*0.003f),transform.position.z);
    }
}
