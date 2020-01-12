using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{

    public GameObject mainMenu;

    private void FixedUpdate()
    {
        if (Input.anyKeyDown)
        {
            gameObject.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
}
