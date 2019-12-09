using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public void SetSensitivity (float sens){
		
		Debug.Log(sens);
		
		MouseCamLook.sensitivity = sens;
	}
}
