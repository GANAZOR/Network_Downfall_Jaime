using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransporter : MonoBehaviour
{
    public string sceneName;

    public void loadPlayScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void loadLoreScene()
    {
        SceneManager.LoadScene("LoreMenu");
    }
    public void loadSettingScene()
    {
        SceneManager.LoadScene("SettingMenu");
    }
    public void loadMainScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void loadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            SceneManager.LoadScene(sceneName);
    }
}
