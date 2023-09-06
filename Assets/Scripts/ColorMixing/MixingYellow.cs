using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixingYellow : MonoBehaviour
{
    [SerializeField] private GameObject greenSquare;
    [SerializeField] private GameObject orangeSqaure;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Blue")
        {
            Instantiate(greenSquare, transform.position, Quaternion.identity);

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Red")
        {
            Instantiate(orangeSqaure, transform.position, Quaternion.identity);

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
