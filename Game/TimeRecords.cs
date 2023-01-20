
// Records and deletes times in timerecords.txt

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class TimeRecords : MonoBehaviour {
    // private string path = Path.Combine(Directory.GetCurrentDirectory(), "\\timerecords.txt");
    public static TimeRecords instance;
    string timePlayed;

    public void Awake() {
        instance = this;
    }
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad() {
        File.WriteAllText(@"D:\timerecords.txt", String.Empty);
    }
    public void RecordTime() {
        timePlayed = TimerController.instance.GetTime().ToString("mm':'ss':'ff");
        File.AppendAllText(@"D:\timerecords.txt", SceneManager.GetActiveScene().name.Replace("_", " ") + ": " + timePlayed + Environment.NewLine);
    }
}
