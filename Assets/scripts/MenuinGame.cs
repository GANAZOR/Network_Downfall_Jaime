using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuinGame : MonoBehaviour
{
    [SerializeField] GameObject pantallaPausa;

    private bool pauseOn = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseOn = !pauseOn;

            pantallaPausa.SetActive(pauseOn);


            if (pauseOn)
            {
                Time.timeScale = 0f;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1f;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}