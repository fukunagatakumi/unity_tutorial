using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockscore : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            FindObjectOfType<Scorecompile>().Addpoint(10);
            Destroy(this.gameObject);
        }
    }
}
