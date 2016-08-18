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

   public void buttonClicked()
    {
        print("Pressed=========");

        //Move the load button off screen
        transform.Translate(-2f, 0, 0);

        //Move refresh button onscreen
        print("Before");
        print(GameObject.FindGameObjectWithTag("refresh").transform.position.ToString());
        GameObject.FindGameObjectWithTag("refresh").transform.Translate(2f, 0, 0);
        print("After");
        print(GameObject.FindGameObjectWithTag("refresh").transform.position.ToString());

        //Move menu panel on screen
        GameObject.FindGameObjectWithTag("menu").transform.Translate(2f, 0, 0);

        //Iterate through images moving them on to the screen
        for (int i =1; i<7; i++)
        {
            //Retrieve image object and move image object on screen
            GameObject.FindGameObjectWithTag("photo" + i.ToString()).transform.Translate(-2f, 0, 0);
        }
        
    }
}


