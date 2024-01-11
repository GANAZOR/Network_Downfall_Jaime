using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keysAndDoors : MonoBehaviour
{
    [SerializeField] GameObject segundoObjetoADestruir;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(segundoObjetoADestruir);
        }
    }
}
