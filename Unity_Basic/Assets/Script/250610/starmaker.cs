using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starmaker : MonoBehaviour
{
    // 1. string.Empty
    // string ������ ���� �ʱ�ȭ �մϴ�.
    /*
    string star;
    star = string.Empty;
        */

    // 2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    /*
    star += "��"; // ��
    star += "��"; // ��ĭ
    star += "\n"; // �ٹٲ�
    */
    // 3. Debug.Log("");
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�



    string star;

    void Start()
    {
        Phase1();
        Phase2();
        /*
        Phase3();
        Phase4();
        */
        Phase5();
        
    }

    public void Phase1()
    {
        star = string.Empty;

        // ������ 1
        for (int i = 1; i <= 5; i++) // �� ��: 1~5
        {
            for (int j = 1; j <= i; j++) // �� ���� �� ����
            {
                star += "��";
            }
            star += "\n"; // �ٹٲ�
        }

        Debug.Log(star); // �ֿܼ� ���
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2
        for (int i = 1; i <= 5; i++) // �� ��
        {
            // ���� �߰�: �ִ� �� �� - ���� �� ��
            for (int j = 1; j <= 5 - i; j++)
            {
                star += "��";
            }

            // �� �߰�
            for (int k = 1; k <= i; k++)
            {
                star += "��";
            }

            // �ٹٲ�
            star += "\n";
        }


        Debug.Log(star);
    }
    /*
    public void Phase3()
    {
        star = string.Empty;

        // ������ 3


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4


        Debug.Log(star);
    }
    */

    public void Phase5()
    {
        star = string.Empty;
    
        // ������ 5
     int n = 5; //���� �߽�
        
        string result = string.Empty; // ���ڿ� �ʱ�ȭ
        //���� �ﰢ��
        for (int i = 1; i < n; i++)
        {
           
            for (int j = 1; j <= n - i; j++)
                result += "��"; // ��ĭ

            for (int j = 1; j <= 2 * i - 1; j++)
                result += "��"; // ��
       
            result += "\n"; // �ٹٲ�
        }
        // �Ʒ��� �ﰢ��
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
                result += "��"; // ��ĭ

            for (int j = 1; j <= 2 * i - 1; j++)
                result += "��"; // ��
            result += "\n";
        }

        Debug.Log(result); // ���� �ﰢ�� ���
    }

}// ��
