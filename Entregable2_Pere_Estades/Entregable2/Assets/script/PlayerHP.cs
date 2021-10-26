using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    public bool isGameOver = false;

    [SerializeField] private int playerHP = 150;

    public int damage = 60;

    // Start is called before the first frame update
    void Start()
    {
        playerHP -= damage;

        if (playerHP <= 0 && isGameOver == true)
        {
            Debug.Log($"Te has quedado sin vida… GAME OVER");
        }
        else if (playerHP <= 30)
        {
            Debug.Log($"¡¡¡Tienes poca vida!!!");
        }
        else
        {
            Debug.Log($"Vas bien de vida: tienes {playerHP} puntos de vida");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
