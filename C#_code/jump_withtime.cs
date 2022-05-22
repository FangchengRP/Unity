using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_withtime : MonoBehaviour
{
    Rigidbody rig;
    
    public float jump_Force = 3.0f;
    public float jump_add_force = 0.1f;

    public float move_speed = 6;
    public LayerMask ground;

    float xMovement;
    float jump_time = 0.0f;
    bool isGround;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        xMovement = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(xMovement * move_speed, rig.velocity.y);

    }
    private void OnCollisionStay(Collision collision)
    {
        var object_name = collision.collider.tag;
        if (object_name == "layer")
        {
            isGround = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            jump_time = Time.time + 0.2f;
            rig.AddForce(new Vector2(0, jump_Force), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Space) && !isGround && Time.time < jump_time)
        {
            rig.AddForce(new Vector2(0, jump_add_force), ForceMode.Impulse);
        }

    }
    
    
}
