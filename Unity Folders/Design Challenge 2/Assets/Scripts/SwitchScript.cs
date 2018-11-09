using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour {

    Animator anim;
    bool guienable = false;
    private Rect userExp = new Rect(Screen.width / 2, Screen.height / 2, 200, 50);
    bool check = false;
 
    // Use this for initialization
    void Start()
    {
        GameObject.Find("Point light").GetComponent<Light>().enabled = check;
        anim = GetComponent<Animator>();
        anim.enabled = false;

    }

    private void OnGUI()
    {
        GUI.enabled = false;
        if (guienable == true)
        {
            GUI.Box(userExp, ("Press E to turn on light"));
        }
    }
    private void OnTriggerStay(Collider other)
    {
        
        guienable = true;

        if (Input.GetButtonDown("Enter"))
        {
            check = !check;
            GameObject.Find("Point light").GetComponent<Light>().enabled = check;

            anim.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        guienable = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}