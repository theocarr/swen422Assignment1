using UnityEngine;
using System.Collections;

public class grabbable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //print("test");
	}

    void OnCollisionEnter(Collision col)
    {
       // print(col);
        if (col.gameObject.tag == "lefthand")
        {
            print("left hand");
        }
        if (col.gameObject.tag == "righthand")
        {
            print("right hand");
        }
    }
}
