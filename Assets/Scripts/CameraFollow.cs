using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player_;
    [SerializeField] private float offset_ = 15f;
    private const float YPosition = 10f;
    private const float XPosition = 0f;
    private void FixedUpdate()
    {
        transform.position = new Vector3(XPosition, YPosition + 5, player_.position.z - offset_);
    }
}
