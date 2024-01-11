using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransporter : MonoBehaviour
{
    public string sceneName;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void loadPlayScene()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void load2Scene()
    {
        SceneManager.LoadScene("2");
    }
    public void load3Scene()
    {
        SceneManager.LoadScene("3");
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
