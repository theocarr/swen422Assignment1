using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Leap.Unity
{
    public class RefreshButtonScript : MonoBehaviour
    {
        public bool touchingHand = false;
        public PinchDetector pinchDetector1;
        public PinchDetector pinchDetector2;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (touchingHand && (pinchDetector1.IsPinching || pinchDetector2.IsPinching))
            {
                buttonClicked();
            }
        }

        void OnCollisionEnter(Collision col)
        {
            // print(col);
            if (col.gameObject.tag == "lefthand")
            {
                touchingHand = true;
            }
            if (col.gameObject.tag == "righthand")
            {
                touchingHand = true;
            }
        }

        void OnCollisionExit(Collision col)
        {
            if (col.gameObject.tag == "lefthand")
            {
                touchingHand = false;
            }
            if (col.gameObject.tag == "righthand")
            {
                touchingHand = false;
            }
        }

        void buttonClicked()
        {
            Application.LoadLevel(1);

        }
    }
}


