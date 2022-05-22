using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_jump : MonoBehaviour
{
    public float jumpForce;
    //跳跃力度

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //0表示左键，1表示右键，2表示中键
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce;
        }
    }
}
