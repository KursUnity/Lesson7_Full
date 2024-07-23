using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looping : MonoBehaviour
{
    int playerHealth = 100;
    bool isGameOver = false;


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���� ������ �� ����� ������ �����
        {
            while(isGameOver == false) // ��������� ���� ����, ���� ���������� isGameOver ����� false
            {
                Debug.Log("� ������ �����: " + playerHealth + "�����");
                playerHealth--;

                if (playerHealth <= 0)
                {
                    isGameOver = true;
                    Debug.Log("��� ����� �����");
                }

                if (playerHealth == 97)
                {
                    Debug.Log("��� ����� �������");
                    return; // ���� � ����� ������� 97 �����, �� ���� ����������� �������������
                }
            } 
        }
    }
}

// ���� ����������� ����� ������
// return - �������������� ���������� �����
