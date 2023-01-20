
// 3 functions for the 3 buttons related to the pause menu

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScreen : MonoBehaviour {
    [SerializeField] GameObject pauseMenu;
    public void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home() {
        Time.timeScale = 1f;
        Initiate.Fade("Menu", Color.black, 1f);
    }
}
