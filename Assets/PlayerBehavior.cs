using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private SlopeManager slopeManager_;

    [SerializeField] private Rigidbody body_;

    [SerializeField] private float moveSpeed_ = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var vel = body_.velocity;
        body_.velocity = new Vector3(vel.x, vel.y, moveSpeed_);
    }

    private void OnTriggerEnter(Collider other)
    {
        slopeManager_.MoveSlope();
    }
}
