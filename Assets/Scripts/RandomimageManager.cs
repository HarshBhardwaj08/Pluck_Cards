using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomimageManager : MonoBehaviour
{
    public static RandomimageManager Instance;
    [SerializeField] private List<Food_SO> lstFoods = new List<Food_SO>();
    
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
