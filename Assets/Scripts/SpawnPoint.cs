using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacle_;

    void Start()
    {
        int rand = Random.Range(0, obstacle_.Length);
        Instantiate(obstacle_[rand], transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}