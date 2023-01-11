using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class EndScreen : MonoBehaviour {
    public TextMeshProUGUI timeRecords;
    void Start() {
        timeRecords.text = File.ReadAllText(@"D:\Development\Unity\Bobertquail Game\Assets\Bobert\Scripts\Game\timerecords.txt");
    }
    public void MenuButton() {
        Initiate.Fade("Menu", Color.black, 1f);
    }
}
