
// 1 function for going to the next level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelScreen : MonoBehaviour {

    public string levelNum;
    public void Next() {
        Time.timeScale = 1f;
        Initiate.Fade("Level_" + levelNum, Color.black, 1f);
    }
}
