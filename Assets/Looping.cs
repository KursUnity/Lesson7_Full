using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looping : MonoBehaviour
{
    int playerHealth = 100;
    bool isGameOver = false;


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Если нажали на левую кнопку мышки
        {
            while(isGameOver == false) // Выполнять блок кода, пока переменная isGameOver равна false
            {
                Debug.Log("У вашего героя: " + playerHealth + "жизни");
                playerHealth--;

                if (playerHealth <= 0)
                {
                    isGameOver = true;
                    Debug.Log("Ваш герой погиб");
                }

                if (playerHealth == 97)
                {
                    Debug.Log("Ваш герой победил");
                    return; // Если у героя остаётся 97 жизни, то цикл завершается принудительно
                }
            } 
        }
    }
}

// Цикл выполняется очень быстро
// return - пренудительное завершение цикла
