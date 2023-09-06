using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerSprite;

    public List<GameObject> colorBox;

    void Start()
    {
    
    }

    
    void Update()
    {
       for(int i = 0; i < 1; i++)
        {
            playerSprite.color = colorBox[i].GetComponent<SpriteRenderer>().color;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MixedColor")
        {
            Debug.Log("change");
            colorBox.Add(collision.gameObject);
        }


        if (collision.gameObject.tag == "Color")
        {
            Debug.Log("change");
            colorBox.Add(collision.gameObject);
        }


        if (colorBox.Count == 2)
        {
            colorBox.RemoveAt(0);
        }

    }
}
