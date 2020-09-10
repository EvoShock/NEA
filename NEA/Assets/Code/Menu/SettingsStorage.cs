using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SettingsStorage : MonoBehaviour
{
    //Still in testing, as currently cannot write correctly

    public void MasterVolume(int Volume)
    {
        string path = "Assets/TxtFiles/Settings.txt";

        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(Volume);
        writer.Close();
    }
}
