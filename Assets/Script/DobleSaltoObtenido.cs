using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DobleSaltoObtenido : MonoBehaviour
{
	private float timer;
	private bool boolTimer;
	public GameObject successText;
    // Update is called once per frame
    void Update()
    {
		Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x,transform.position.y),0.2f);
        foreach(Collider2D collider in colliders)
		{
			if(collider.gameObject.tag == "Player")
			{	
				 collider.gameObject.GetComponent<CharacterController2D>().doubleJump = true;
				 successText.GetComponent<TextMeshProUGUI>().enabled = true;
				 successText.GetComponent<Show>().show = true;
				 Destroy(GetComponent<SpriteRenderer>());
				 Destroy(this);
				 
			}
		}
		
    }
	
}
