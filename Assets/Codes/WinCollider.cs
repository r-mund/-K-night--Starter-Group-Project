using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCollider : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player") 
        {
          SceneManager.LoadScene("Winning");
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene("Winning");
    }
}
