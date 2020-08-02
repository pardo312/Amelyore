using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEBG : MonoBehaviour
{
    private float length, startpos,distCamStart,dist, camPosAnterior;
	public GameObject cam;
	public float parallaxEffect;
	
    // Start is called before the first frame update
    void Start()
    {
		
        startpos = transform.position.x ;
		distCamStart = cam.transform.position.x - startpos;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		float camPos = cam.transform.position.x;
	
		startpos =  cam.transform.position.x - distCamStart;
		float pos = cam.transform.position.x - (transform.position.x - 30);
		//Si el jugador camina hacia atras
		if(	camPos < camPosAnterior)
		{
			
			dist += (1 * (parallaxEffect+ 0.1f));
		}
		//Si el jugador camina hacia adelante
		else if(camPos > camPosAnterior) {
			dist += (1 * (parallaxEffect - 0.1f));
		}
		else
		{
			dist += (1 * parallaxEffect);
		}
        
		camPosAnterior = cam.transform.position.x;
		transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
		if(pos<0) dist = 0;
		
	}
}
