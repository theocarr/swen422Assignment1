using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RefreshButtonScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        // print(col);
        if (col.gameObject.tag == "lefthand")
        {
            buttonClicked();
        }
        if (col.gameObject.tag == "righthand")
        {
            buttonClicked();
        }
    }

    void buttonClicked()
    {
        Application.LoadLevel(1);
    
    }
}


