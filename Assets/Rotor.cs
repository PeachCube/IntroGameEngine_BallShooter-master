using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(0, -120, 0) * Time.deltaTime);
    }
}
