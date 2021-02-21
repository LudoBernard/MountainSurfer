using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject obstacle_;

    void Start()
    {
        Instantiate(obstacle_, transform.position, Quaternion.identity);
    }
}
