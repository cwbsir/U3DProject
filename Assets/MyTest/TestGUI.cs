using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnGUI()
    {
    	GUI.Button(new Rect(0, 0, 100, 30), "Button");
    	GUI.Label(new Rect(100, 0, 100, 30), "Label");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
