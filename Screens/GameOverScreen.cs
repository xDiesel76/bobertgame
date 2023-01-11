
// 2 functions for the 2 buttons on the game over screen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour {
    
    public void RestartButton() {
        Initiate.Fade(SceneManager.GetActiveScene().name, Color.black, 1f);
    }

    public void ExitButton() {
        Initiate.Fade("Menu", Color.black, 1f);
    }
}
