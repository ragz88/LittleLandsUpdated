using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0)  ;
    }
}
