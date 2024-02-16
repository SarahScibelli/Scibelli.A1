using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Camera3rd;
    public GameObject Camera1st;
    bool persp = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (persp == true)
            {
                CameraOne();
                persp = false;
            }
            else if (persp == false)
            {
                CameraThree();
                persp = true;
            }

       
        }
 

        void CameraOne ()
        {
            Camera1st.SetActive (true);
            Camera3rd.SetActive (false);
        }

        void CameraThree()
        {
            Camera1st.SetActive(false);
            Camera3rd.SetActive(true);
        }

    }
}
