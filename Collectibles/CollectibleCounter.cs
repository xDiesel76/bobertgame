
// Counts total amount of collectibles
// Once count reaches 0 the continue button will show up allowing the player to continue

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectibleCounter : MonoBehaviour {
    private int Collectibles;

    public TextMeshProUGUI numCollectibles;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject continueMenu;

    void Update() {
        Collectibles = GameObject.FindGameObjectsWithTag("Collectible").Length;
        numCollectibles.text = Collectibles.ToString();

        if (Collectibles == 0 || Input.GetKey("p")) {
            TimerController.instance.EndTimer();
            TimeRecords.instance.RecordTime();
            pauseMenu.SetActive(false);
            continueMenu.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}
