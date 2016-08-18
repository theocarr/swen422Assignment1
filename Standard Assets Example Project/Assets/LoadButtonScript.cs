using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadButtonScript : MonoBehaviour
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
       
        GameObject[] photos = new GameObject[6];

        float x, y, z;

        for (int i =1; i<7; i++)
        {
            GameObject photo = GameObject.FindGameObjectWithTag("photo" + i.ToString());
            x = photo.transform.position.x;
            y = photo.transform.position.y;
            z = photo.transform.position.z;
            photo.transform.Translate(x+2, y, z, Camera.main.transform);
        }



       
    }
}


