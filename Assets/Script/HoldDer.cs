using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoldDer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
	private bool pointerDown;
	private float pointerDownTimer;
    // Update is called once per frame
    void Update()
    {
        if(pointerDown)
		{
			pointerDownTimer += Time.deltaTime;
		}
    }
	public void OnPointerDown(PointerEventData eventData){
		
		pointerDown = true;
		player.GetComponent<PlayerMove>().moveRight();
	}
	public void OnPointerUp(PointerEventData eventData){
		
		pointerDown = false;	
		player.GetComponent<PlayerMove>().stopRight();
	}
}
