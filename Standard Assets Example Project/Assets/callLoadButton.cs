using UnityEngine;
using System.Collections;

namespace Leap.Unity
{
    public class callLoadButton : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            GameObject.FindWithTag("load").GetComponent<LoadButtonScript>().buttonClicked();



        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
