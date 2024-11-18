using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour
{
    private float seed;
    // Start is called before the first frame update
    void Start()
    {
        seed = UnityEngine.Random.Range(0.0f,1.0f);
        print(seed);
    }

    // Update is called once per frame
    void Update()
    {
        Light candle = gameObject.GetComponent<Light>();
   
        candle.intensity = Mathf.PerlinNoise(Time.timeSinceLevelLoad+seed,0) * 10;
    }
}
