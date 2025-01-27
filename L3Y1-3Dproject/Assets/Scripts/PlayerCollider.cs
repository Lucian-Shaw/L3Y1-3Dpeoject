using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public Vector3 lastPos;

    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KillTrigger"))
        {
            transform.position = lastPos;
        }

        if (other.gameObject.CompareTag("checkpoint"))
        {
            lastPos = transform.position;
        }
    }


}
