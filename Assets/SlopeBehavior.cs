using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeBehavior : MonoBehaviour
{
    [SerializeField] private SlopeManager slopeManager_;
    [SerializeField] private Rigidbody body_;

    private float moveSpeed_ = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {
        var vel = body_.velocity;
        body_.velocity = new Vector3(vel.x, vel.y, -moveSpeed_);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slopeManager_.MoveSlope();
        }
    }
}
