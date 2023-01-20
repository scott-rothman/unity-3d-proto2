using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float speed = 40f;
    private float topPosBounds = 30f;
    private float bottomPosBounds = -10f;
    private

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z > topPosBounds)
        {
            Destroy(gameObject);
        }
        else if (
            transform.position.z < bottomPosBounds &&
            gameObject.tag == "LethalProjectile"
        ) 
        {
            Debug.Log("Game Over!!!");
            Destroy(gameObject);
        }
    }
}
