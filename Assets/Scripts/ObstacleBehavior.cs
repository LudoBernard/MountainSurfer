using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleBehavior : MonoBehaviour
{
    [SerializeField] private float speed_;
    [SerializeField] private float sideSpeed_;
    
    [SerializeField] private float increaseSpeed_;
    [SerializeField] private float maxSpeed_;
    
    [SerializeField] private float increaseSideSpeed_;
    [SerializeField] private float maxSideSpeed_;

    private Vector3 moveSide_ = Vector3.right;
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.back * speed_ * Time.deltaTime);
        if (transform.position.z <= -24)
        {
            Destroy(gameObject);
        }

        if (gameObject.CompareTag("Moving"))
        {
            transform.Translate(moveSide_ * sideSpeed_ * Time.deltaTime);
        }
        
        if (speed_ < maxSpeed_)
        {
            speed_ += increaseSpeed_ * Time.deltaTime;
        }

        if (sideSpeed_ < maxSideSpeed_)
        {
            sideSpeed_ += increaseSideSpeed_ * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.CompareTag("Waypoint"))
        {
            moveSide_ = -moveSide_;
        }
    }
}
