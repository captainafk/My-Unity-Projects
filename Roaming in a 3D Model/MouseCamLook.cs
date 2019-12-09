using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamLook : MonoBehaviour
{
    [SerializeField]
    public static float sensitivity = 3.0f;
    [SerializeField]
    public float smoothing = 2.0f;
    public GameObject character;
    // Get the incremental value of mouse movement
    private Vector2 mouseLook;
    // Smoothen the mouse movement
    private Vector2 smoothV;

    // Use this for initialization
    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
		#if UNITY_EDITOR || UNITY_STANDALONE
        // md is the mouse delta value
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        // Interpolated float result between the two float values
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        // Incrementally adding this value to the camera look to make it smoother
        mouseLook += smoothV;

		// Constraint mouseLook in y direction
		if (mouseLook.y > 90){
			mouseLook.y = 90;
		}else if (mouseLook.y < -90){
			mouseLook.y = -90;
		}
		
        // vector3.right means the x-axis
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
		#endif
		
		#if UNITY_ANDROID || UNITY_IOS
		
		//TODO
		#endif
    }
}
