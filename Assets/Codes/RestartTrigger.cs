using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine; 

public class RestartTrigger : MonoBehaviour
{
    public GameManager gameManager;
  void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
