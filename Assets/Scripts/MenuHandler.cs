using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public GameObject playerNameBox;

    public void OnStart()
    {
        var name = playerNameBox.GetComponent<Text>().text;
        //Debug.Log(name);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
