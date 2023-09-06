using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletMove : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private int pelletSpeed;
    
    void Start()
    {
        StartCoroutine(Move());
    }


    IEnumerator Move()
    {
        rb.velocity += new Vector2(0f, pelletSpeed * Time.deltaTime);

        yield return new WaitForSeconds(1f);

        rb.velocity = new Vector2(0f, 0f);

        yield return null;
    }
}
