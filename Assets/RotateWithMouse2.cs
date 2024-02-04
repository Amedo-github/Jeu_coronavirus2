using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateWithMouse2 : MonoBehaviour
{
    //public GameObject cone;
   // public GameObject cylindre;
    public static Vector3 direction;
   

   
    public GameObject virus;
    float yaw;//angle horiz.
    float pitch;//angle vertic.
    float mouseSensitivity = 1;

    Vector3 currentRotation;

    //public static Transform trCylindreDirection;
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
      
        pitch = 45;
    }

    // Update is called once per frame
    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;//negatif si va a gauche
        //Debug.Log(yaw);
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        //Debug.Log(pitch);
        if (pitch > 0)
            pitch = 0;
        if (pitch <-30)
            pitch =-30;
        if (yaw > 30)
            yaw = 30;
        if (yaw < -30)
            yaw = -30;

        currentRotation = new Vector3(pitch,yaw, 0);//rot autour de X ou Y
        transform.eulerAngles = currentRotation;
        direction = currentRotation;

       //direction = transform.;
       
       // Debug.Log(direction);
     /*
        inputH += Input.GetAxis("Horizontal");
        inputV += Input.GetAxis("Vertical");
        angleHoriz = inputH;
        angleVert = inputV;
        if(inputV>90)
        {
            inputV = 90;
        }
        if (inputV < 0)
        {
            inputV = 0;
        }
        //angleVert =Mathf.Clamp(45+inputV,0,90);
        transform.eulerAngles = new Vector3(angleVert, angleHoriz, 0);

        textFx.text = direction.x.ToString("F1");
        textFy.text = direction.y.ToString("F1");
        textFz.text = direction.z.ToString("F1");
        textAlpha.text = "Angle horizontal autour axe Y= " + transform.eulerAngles.y.ToString("F1");
        textTeta.text = "Angle vertical autour axe X= " + transform.eulerAngles.x.ToString("F1");

        //lrProjectionDirection.SetPosition(1, new Vector3(direction.x*1000, .5f,direction.z*1000));
        
    */


    }
}
