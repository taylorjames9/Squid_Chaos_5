using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class CameraFunctions : MonoBehaviour {


	public Camera myCameraOBJ;
	public Canvas myGUICanvas;
	public GameObject firstPersonController;
	//public Button cameraOnOFFButton;

	// Use this for initialization
	void Start () {
	
		myCameraOBJ.gameObject.SetActive(false);
		myGUICanvas.gameObject.SetActive(false);
		myCameraOBJ.cullingMask = 1 << LayerMask.NameToLayer("Nothing");

	}

	public void OnTriggerEnter(){
		Debug.Log ("Trigger Enter");
		myGUICanvas.gameObject.SetActive(true);
		firstPersonController.GetComponent<FirstPersonController>().SetGUI_Out(true);

	}

	public void TurnCameraON(){
		Debug.Log ("CAMERA TURN ON");
		myCameraOBJ.gameObject.SetActive(true);

	}

	public void TurnCameraOFF(){
		Debug.Log ("CAMERA TURN OFF");
		myCameraOBJ.gameObject.SetActive(false);
		
	}

	public void EXIT(){

		myGUICanvas.gameObject.SetActive(false);
		firstPersonController.GetComponent<FirstPersonController>().SetGUI_Out(false);

	}

	public void SwitchRenderTo_Lay_1(){
		Debug.Log ("layer set to = "+LayerMask.NameToLayer("Gear_1"));
		myCameraOBJ.cullingMask = 1 << LayerMask.NameToLayer("Gear_1");
	}

	public void SwitchRenderTo_Lay_2(){
		Debug.Log ("layer set to = "+LayerMask.NameToLayer("Gear_2"));
		myCameraOBJ.cullingMask = 1 << LayerMask.NameToLayer("Gear_2");

	}

	public void SwitchRenderTo_Lay_3(){
		Debug.Log ("layer set to = "+LayerMask.NameToLayer("Squid"));
		myCameraOBJ.cullingMask = 1 << LayerMask.NameToLayer("Squid");

	}



}
