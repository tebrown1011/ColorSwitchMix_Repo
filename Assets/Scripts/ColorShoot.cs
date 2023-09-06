using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShoot : MonoBehaviour
{
    [SerializeField] private GameObject bluePellet;
    [SerializeField] private GameObject yellowPellet;
    [SerializeField] private GameObject redPellet;

    [SerializeField] private Transform pelletSpawner;

    public GameObject player;

    [SerializeField] private SpriteRenderer playerSprite;
    
    void Update()
    { 

        if (player.GetComponent<PlayerColor>().isBlue == true && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bluePellet, transform.position, Quaternion.identity);
            player.GetComponent<ColorChange>().colorBox.RemoveAt(0);
            player.GetComponent<PlayerColor>().isBlue = false;
            playerSprite.color = new Color(1, 1, 1);
        }

        if (player.GetComponent<PlayerColor>().isRed == true && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(redPellet, transform.position, Quaternion.identity);
            player.GetComponent<ColorChange>().colorBox.RemoveAt(0);
            player.GetComponent<PlayerColor>().isRed = false;
            playerSprite.color = new Color(1, 1, 1);
        }

        if (player.GetComponent<PlayerColor>().isYellow == true && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(yellowPellet, transform.position, Quaternion.identity);
            player.GetComponent<ColorChange>().colorBox.RemoveAt(0);
            player.GetComponent<PlayerColor>().isYellow = false;
            playerSprite.color = new Color(1, 1, 1);
        }
    }
}
