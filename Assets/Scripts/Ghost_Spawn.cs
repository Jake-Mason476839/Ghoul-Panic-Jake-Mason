using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Spawn : MonoBehaviour
{
    public GameObject ObjectToSpawn;   
    public float RateOfSpawn = 1;
   
    private float nextSpawn = 0;
 
    // Update is called once per frame
    void Update ()
    {           
       
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + RateOfSpawn;
           
            // Random position within this transform
            Vector3 rndPosWithin;
            rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
            Instantiate(ObjectToSpawn, rndPosWithin, transform.rotation * Quaternion.Euler (0f, 0f, 180f));
        }
    }
}
