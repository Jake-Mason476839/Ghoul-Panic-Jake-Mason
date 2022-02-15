using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Kill : MonoBehaviour
{
    void OnPointerDown()
    {
        Destroy(gameObject);
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
