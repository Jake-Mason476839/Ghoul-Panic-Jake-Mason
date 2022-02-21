using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Kill : MonoBehaviour
{
    public float timer = 0.0f;

    void Update()
    {
        timer ++;

        if (timer == 75.0f)
        {
            Destroy(gameObject);
        }

        else if (timer == 80.0f)
        {
            timer = 0.0f;
        }
    }

    void OnPointerDown()
    {
        Destroy(gameObject);
        Timer.ghostCount += 1;
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        Timer.ghostCount += 1;
    }
}
