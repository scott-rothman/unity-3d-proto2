using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float speed = 40f;
    private float topPosBounds = 30f;
    private float bottomPosBounds = -10f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z > topPosBounds ||
            transform.position.z < bottomPosBounds)
        {
            Destroy(gameObject);
        }
    }
}
