using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string name = "��ä��";
    private int age = 25;
    private int height = 158;
    private string bloodType = "AB��";
    private string mbti = "ESTJ";
    private string hobby = "K-pop ���� ���";
    private string favoriteFood = "����";
    private string favoriteGame = "���÷���";
    private string desiredJob = "���� PM";
    void Start()
    {
        SelfIntroduction();
    }

    public void SelfIntroduction()
    {
        Debug.Log($"�� �̸��� {name}�Դϴ�.");
        Debug.Log($"���� ���̴� {age}���Դϴ�.");
        Debug.Log($"Ű�� {height}cm�Դϴ�.");
        Debug.Log($"�������� {bloodType}�Դϴ�.");
        Debug.Log($"MBTI�� {mbti}�Դϴ�.");
        Debug.Log($"��̴� {hobby}�Դϴ�.");
        Debug.Log($"�����ϴ� ������ {favoriteFood}�Դϴ�.");
        Debug.Log($"�־� ������ {favoriteGame}�Դϴ�.");
        Debug.Log($"��� ������ {desiredJob}�Դϴ�.");
    }
}