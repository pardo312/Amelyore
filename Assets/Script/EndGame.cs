using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
	private float timer;
	private bool boolTimer;
	public GameObject successText;
	public GameObject player;
    // Update is called once per frame
    void Update()
    {
		Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x,transform.position.y),0.2f);
        foreach(Collider2D collider in colliders)
		{
			if(collider.gameObject.tag == "Player")
			{	
				 player.GetComponent<PlayerMove>().fin = true;
				 successText.GetComponent<TextMeshProUGUI>().enabled = true;
				 successText.GetComponent<Show>().show = true;
					
				 Destroy(this);
				 
			}
		}
		
    }
}
