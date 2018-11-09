using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {
    Animator anim;
    bool guienable = false;
    private Rect userExp = new Rect(Screen.width / 2, Screen.height / 2, 200, 50);
<<<<<<< HEAD
    private AudioSource audio;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        anim.enabled = false;
        audio = GetComponentInChildren<AudioSource>();


    }

=======
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        anim.enabled = false;
        
    }

>>>>>>> c73980ef5518c47dcd1a1ac40b30fdd72e43edb4
    private void OnGUI()
    {
        GUI.enabled = false;
        if (guienable == true)
        {
            GUI.Box(userExp, ("Press E to open door"));
        }
    }
    private void OnTriggerStay(Collider other)
    {
        guienable = true;

        if (Input.GetButtonDown("Enter"))
        {

           
            anim.enabled = true;
<<<<<<< HEAD
            audio.Play();

=======
>>>>>>> c73980ef5518c47dcd1a1ac40b30fdd72e43edb4
        }
    }
    private void OnTriggerExit(Collider other) {
        guienable = false;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
