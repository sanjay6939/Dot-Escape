using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour

{
    
    
    [SerializeField] float controlSpeed;
    //touch
    [SerializeField] bool isTouching;
    float touchPosX;
    Vector3 direction;


    

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }
    private void FixedUpdate()
    {
        
        if (isTouching)
        {
            touchPosX += Input.GetAxis("Mouse X") * controlSpeed * Time.fixedDeltaTime;
        }
        transform.position = new Vector3(touchPosX, transform.position.y, transform.position.z);
    }
    void GetInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }
}
