using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public bool isYellow;
    public bool isBlue;
    public bool isRed;

    [SerializeField] private SpriteRenderer playerSprite;

    public float redValue;
    public float greenValue;
    public float blueValue;


    private void Start()
    {

    }
    void Update()
    {
        redValue = playerSprite.color.r;
        greenValue = playerSprite.color.g;
        blueValue = playerSprite.color.b;


        if (redValue == 1 && greenValue == 1 && blueValue == 0)
        {
            isYellow = true;
            isRed = false;
            isBlue = false;
        }


        else if (redValue == 1 && greenValue == 0 && blueValue == 0)
        {
            isYellow = false;
            isRed = true;
            isBlue = false;
        }


        else if (redValue == 0 && greenValue == 0 && blueValue == 1)
        {
            isYellow = false;
            isRed = false;
            isBlue = true;
        }
        else
        {
            isYellow = false;
            isRed = false;
            isBlue = false;
        }
    }
}
