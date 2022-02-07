using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandFollow : MonoBehaviour
{
    Camera cam;

    Image image;

    public float xMultiplier, yMultiplier;

    private void Start()
    {
        cam = Camera.main;
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPortPoint = cam.ScreenToViewportPoint(Input.mousePosition);

        transform.position = new Vector3(viewPortPoint.x * xMultiplier, viewPortPoint.y * yMultiplier, 0);

        if (Input.GetMouseButton(0))
        {
            image.enabled = true;
        }
        else
        {
            image.enabled = false;
        }
    }
}
