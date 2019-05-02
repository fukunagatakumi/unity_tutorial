using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockcontroller : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
