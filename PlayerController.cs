using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0f;
    private float translation;
    private float strafe;
	private float go_up_or_down;
	public Joystick joystick;

    // Use this for initialization
    void Start()
    {
        // Turn off the cursor
        Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
		#if UNITY_EDITOR || UNITY_STANDALONE
        // Input.GetAxis() is used to get the user's input
        // You can further set it on Unity. (Edit, Project Settings, Input)
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        strafe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		go_up_or_down = Input.GetAxis("GoUpOrDown") * speed * Time.deltaTime;
        transform.Translate(strafe, go_up_or_down, translation);
		#endif

        if (Input.GetKeyDown("escape"))
        {
            // Turn on the cursor
            Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene(0);
			Cursor.visible = true;
        }
		
		#if UNITY_ANDROID || UNITY_IOS
		//TODO
		translation = joystick.Vertical * speed;
		strafe = joystick.Horizontal * speed;
		transform.Translate(strafe, 0, translation);
		
		#endif
    }
}