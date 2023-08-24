using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMainGame : MonoBehaviour
{
    public GameObject MainGameCanvas;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;

    private void Start()
    {
        MainGameCanvas.SetActive(false);   
    }

    private void Update()
    {
        if(!playerHealth.isActiveAndEnabled)
        {
            MainGameCanvas.SetActive(true);

        }
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }


}
