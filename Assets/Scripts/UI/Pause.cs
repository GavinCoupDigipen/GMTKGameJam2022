//------------------------------------------------------------------------------
//
// File Name:	Pause.cs
// Author(s):	Gavin Cooper (gavin.cooper)
// Project:	    GMTK GameJam 2022
//
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [Tooltip("The button to open the pause screen")] [SerializeField]
    private KeyCode pauseKey = KeyCode.Return;

    private GameObject canvas;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        canvas = gameObject.transform.GetChild(0).gameObject;

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            //if (isPaused)
            //{
            //    UnPauseGame();
            //}

            if (!isPaused)
            {
                PauseGame();
            }
        }
    }

    // Pause the game
    private void PauseGame()
    {
        Time.timeScale = 0;
        canvas.SetActive(true);
    }

    // Unpause the game
    public void UnPauseGame()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
}
