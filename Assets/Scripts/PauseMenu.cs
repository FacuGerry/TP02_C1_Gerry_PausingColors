using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    bool isPause = true;
    void Awake()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            if (isPause)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }



    void Pause()
    {
        Time.timeScale = 0;
    }

    void Resume()
    {
        Time.timeScale = 1;
    }

}
