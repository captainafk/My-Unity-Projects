using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class Maths : MonoBehaviour
{
    public Text mainInputField;
	public Text scoreText;
	public Text mathsText;
	private float math1;
	private float math2;
	private float result;
	private int score;

    public void Start()
    {
        score = 0;
		GenerateMath();
		scoreText.text = "Score: 0";
		mainInputField.text = "";
    }
	
	public void Update(){
		if (mainInputField.text == result.ToString()){
			score += 1;
			GenerateMath();
			scoreText.text = "Score: " + score.ToString();
			mainInputField.text = "";
		}
		
		if (Input.GetKeyDown(KeyCode.Alpha1)){
			mainInputField.text += "1";
		}if (Input.GetKeyDown(KeyCode.Alpha2)){
			mainInputField.text += "2";
		}else if (Input.GetKeyDown(KeyCode.Alpha3)){
			mainInputField.text += "3";
		}else if (Input.GetKeyDown(KeyCode.Alpha4)){
			mainInputField.text += "4";
		}else if (Input.GetKeyDown(KeyCode.Alpha5)){
			mainInputField.text += "5";
		}else if (Input.GetKeyDown(KeyCode.Alpha6)){
			mainInputField.text += "6";
		}else if (Input.GetKeyDown(KeyCode.Alpha7)){
			mainInputField.text += "7";
		}else if (Input.GetKeyDown(KeyCode.Alpha8)){
			mainInputField.text += "8";
		}else if (Input.GetKeyDown(KeyCode.Alpha9)){
			mainInputField.text += "9";
		}else if (Input.GetKeyDown(KeyCode.Alpha0)){
			mainInputField.text += "0";
		}else if (Input.GetKeyDown(KeyCode.Backspace)){
			mainInputField.text = "";
		}
	}
	
	private void GenerateMath(){
		math1 = Random.Range(0,10 + score * 3);
		math2 = Random.Range(2,12 + score * 3);
		result = math1 + math2;
		mathsText.text = math1.ToString() + " + " + math2.ToString() + " ?";
	}
}