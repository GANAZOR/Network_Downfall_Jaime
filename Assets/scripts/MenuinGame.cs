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

            Cursor.visible = pauseOn;

            if (pauseOn)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}