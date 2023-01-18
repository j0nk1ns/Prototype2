﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
  
  private float topBound = 30; 
  private float loweround = -10; 
 

  // Start is called before the first frame update 
  void Start()

  { 

  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.z > topBound)
    {  
     Destroy(gameObject);
    }
    else if (transform.position.z < loweround)
    {
      Debug.Log("Game Over!");
     Destroy(gameObject);
    }
  }

} 
