using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float xIncrement_;
    [SerializeField] private float maxX_;
    [SerializeField] private float minX_;
    private Vector3 targetPos_;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX_) //left
        {
            targetPos_ = new Vector3(transform.position.x - xIncrement_, transform.position.y, transform.position.z);
            transform.position = targetPos_;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX_) //right
        {
            targetPos_ = new Vector3(transform.position.x + xIncrement_, transform.position.y, transform.position.z);
            transform.position = targetPos_;
        }
    }
}
