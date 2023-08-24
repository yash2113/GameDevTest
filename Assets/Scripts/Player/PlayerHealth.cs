using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int HP = 100;
    public Animator playerAnimator;
    public Animator enemyAnimator;
    GameObject player;
    private Vector3 initialPosition;
    public Slider healthSlider;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = player.transform.position;
    }

    private void Update()
    {
        healthSlider.value = HP;
    }
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <= 0)
        {
            playerAnimator.SetTrigger("die");
 
            player.SetActive(false);
            SceneManager.LoadScene(0);
        }
        else
        {
            playerAnimator.SetTrigger("damage");
        }
    }

  

    public void ResetEverything()
    {
        HP = 100;
        player.transform.position = initialPosition;
    }

    
}
