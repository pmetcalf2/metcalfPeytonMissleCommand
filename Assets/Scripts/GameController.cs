using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public string sceneToLoad;
    public int health = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void RestartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKey(KeyCode.R))
        {
            RestartGame();
        }
    }
    public void LoseHealth()
    {
        health--;
       ;
        if (health <= 0)
        {
            RestartGame();

        }



    }

}
