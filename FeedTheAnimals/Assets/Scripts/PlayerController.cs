using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
  Naming convention used
  - PascalCasing for public variables
  - _camelCasing for public or protected variables
  - camelCasing for local varibles

*/
public class PlayerController : MonoBehaviour
{
    float _horizontalInput;
    public float Speed;
    // Start is called before the first frame update
    float _bound = 14f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         //movement 
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * Speed);

        /*
            We did the movement of the player and then we checked bounds , because...
                - When movement is done after the bound check , the player position may go beyond the bound values .Only in 
                  next update call the position is set to bounded values
                - This avoids jittering while change in position
                - while bound is checked within the same call of Update(which did the movement now it checks the bound) , 
                  player is re-positioned on that function call(Update).
                - So the jittery thing is avoided
        */

        //to keep player inbound(inside the screen)
        if(transform.position.x < -_bound ) transform.position = new Vector3(-14 , transform.position.y , transform.position.z);
        if(transform.position.x > _bound ) transform.position = new Vector3(14 , transform.position.y , transform.position.z);

       
    }
}
