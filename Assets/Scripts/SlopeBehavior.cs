using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeBehavior : MonoBehaviour
{

    [SerializeField] private float moveSpeed_;
    [SerializeField] private float increaseSpeed_;
    [SerializeField] private float maxSpeed_;
    [SerializeField] private SlopeManager slopeManager_;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed_ * Time.deltaTime);
        if (moveSpeed_ < maxSpeed_)
        {
            moveSpeed_ += increaseSpeed_ * Time.deltaTime;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slopeManager_.MoveSlope();
        }
    }
}
