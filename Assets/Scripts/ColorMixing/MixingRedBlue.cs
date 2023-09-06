using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixingRedBlue : MonoBehaviour
{
    [SerializeField] private GameObject purpleSquare;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Red")
        {
            Instantiate(purpleSquare, transform.position, Quaternion.identity);

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
