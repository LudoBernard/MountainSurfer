using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstaclePatternSpawner : MonoBehaviour
{
   [SerializeField] private GameObject[] obstaclePatterns_;

   private float timeBtwSpawn_;
   [SerializeField] private float startTimeBtwSpawn_;
   [SerializeField] private float decreaseTime_;
   private float minTime_ = 0.3f;

   private void Update()
   {
      if (timeBtwSpawn_ <= 0)
      {
         int rand = Random.Range(0, obstaclePatterns_.Length);
         Instantiate(obstaclePatterns_[rand], transform.position, Quaternion.identity);
         timeBtwSpawn_ = startTimeBtwSpawn_;
         if (startTimeBtwSpawn_ > minTime_)
         {
            startTimeBtwSpawn_ -= decreaseTime_;
         }
      }
      else
      {
         timeBtwSpawn_ -= Time.deltaTime;
      }
   }
}
