using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDeath : MonoBehaviour
{
	
	public Transform ground;
	public Scene scene;
    // Update is called once per frame
    void Update()
    {
      Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(ground.position.x,ground.position.y),0.2f);
        foreach(Collider2D collider in colliders)
		{
			
			if(collider.gameObject.tag == "Death")
			{
				SceneManager.LoadScene("Level1");
			}
		}
    }
}
