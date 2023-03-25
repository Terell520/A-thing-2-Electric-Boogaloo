using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float Speed = 10f;

    public float speed;

    public float upRotation;
    public float downRotation;

    float thisISDecimal = 3.14f;
    CharacterController CharacterControl;
    public Transform playerCam;

    Vector3 vel;

    public float lookSensitivity;

    float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {

        CharacterControl = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        CharacterControl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
        
    {

        transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0);
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
        xRotation = Mathf.Clamp(xRotation, -upRotation, downRotation);
        playerCam.localRotation = Quaternion.Euler(xRotation, 0, 0);

        vel.z = Input.GetAxis("Vertical") * speed;
        vel.x = Input.GetAxis("Horizontal") * speed;

        vel = transform.TransformDirection(vel);
        CharacterControl.Move(vel * Time.deltaTime);

        //WASD controls
        
          
            Vector3 currentPos = transform.position;
           

           


        
    }
}
