using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeScene : MonoBehaviour
{
    public GameObject startGameCanvas;
    public GameObject gameInstCanvas;
    public GameObject gameControllerCanvas;

    private void Start()
    {
        startGameCanvas.SetActive(true);
        gameInstCanvas.SetActive(false);
        gameControllerCanvas.SetActive(false);
    }

    public void OpenKeyboardCanvas()
    {
        startGameCanvas.SetActive(false);
        gameInstCanvas.SetActive(true);
        gameControllerCanvas.SetActive(false);
    }

    public void OpenControllerCanvas()
    {
        startGameCanvas.SetActive(false);
        gameInstCanvas.SetActive(false);
        gameControllerCanvas.SetActive(true);
    }

    public void ReturnToMainCanvas()
    {
        startGameCanvas.SetActive(true);
        gameInstCanvas.SetActive(false);
        gameControllerCanvas.SetActive(false);
    }

    public void MenuToGame()
    {
        SceneManager.LoadScene(1);
    }

    public void EndToMenu()
    {
        SceneManager.LoadScene(0);
    }


}
