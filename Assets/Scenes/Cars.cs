using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{

    [SerializeField] float steerSpeed = 0.3f;
    [SerializeField] float moveSpeed = 0.02f;

    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
