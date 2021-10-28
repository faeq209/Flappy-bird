using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{
    public GameObject Gameover;
    // Start is called before the first frame update
   public void PlayGame()
    {
        SceneManager.LoadScene(1);

    }
    public void gameover()
    {
        Time.timeScale = 0;
        Gameover.SetActive(true);

    }
    public void restartgame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
