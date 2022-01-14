using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuHandler : MonoBehaviour
{
    public GameObject playerNameBox;

    public void OnStart()
    {
        var name = playerNameBox.GetComponent<Text>().text;
        DataKeeper.Instance.currentPlayerName = name;

        SceneManager.LoadScene("main");
    }
}
