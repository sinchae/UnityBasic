using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update

    /*
    void Start()
    {
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // Ȯ���� 30%�� �α׿� 'ġġ'�� �̾Ҵ�!

        if (Random.Range(0, 100) < 10) //10% Ȯ��
        {
            Debug.Log("��û�� �̾Ҵ�!");
        }
        else if (Random.Range(0, 100) < 20) //20%�� Ȯ��
        {
            Debug.Log("�𳪸� �̾Ҵ�!");
        }
        else if (Random.Range(0, 100) < 30) //30%�� Ȯ��
        {
            Debug.Log("ġġ�� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("�ƹ��͵� ���� ���ߴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}   
    */
    
        void Start()
    {

        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // Ȯ���� 30%�� �α׿� 'ġġ'�� �̾Ҵ�!

        int randomValue = Random.Range(0, 101); // 0���� 99������ ���� �� ����

        if (randomValue <= 10) //1~10 -> 10% Ȯ��
        {
            Debug.Log("��û�� �̾Ҵ�!");
        }
        else if (randomValue <= 20) //20%�� Ȯ��
        {
            Debug.Log("�𳪸� �̾Ҵ�!");
        }
        else if (randomValue <= 30) //30%�� Ȯ��
        {
            Debug.Log("ġġ�� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("�ƹ��͵� ���� ���ߴ�.");
        }
    }

    void Update()
    {

    }
}