using UnityEngine;
using System.Collections;

public class callLoadButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.FindWithTag("load").GetComponent<LoadButtonScript>().buttonClicked();//.GetComponent("LoadButtonScript").buttonClicked(); ;//.GetComponent<"LoadButtonScript">().buttonClicked();
                                                                  //a.GetComponent(LoadButtonScript).buttonClicked();


    }

    // Update is called once per frame
    void Update () {
	
	}
}
