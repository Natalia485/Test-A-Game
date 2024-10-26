using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
