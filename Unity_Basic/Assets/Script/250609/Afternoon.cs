using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Active0609 : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    // List
    private List<string> characterList = new List<string>
    {
        "��ä��", "������", "�����", "��ȣ��", "����ȯ", "���¿�", "������", "Ȳ�μ�", "�����", "�̹α�"
    };

    // 10���� ��í ���� - onClick�� ����
    public void classGatcha()
    {
        // ���ڿ� �ʱ�ȭ
        string result = "����� 10���� ��� \n";

        // 2) for������ 10�� �̱�
        for (int i = 0; i < 10; i++)
        {
            int idx = Random.Range(0, characterList.Count);
            // ���ڿ� �������� �� �پ� �߰�
            result += $"{i + 1}��°: {characterList[idx]}��\n";
        }

        // ���ο� ���
        resultText.text = result;
        Debug.Log(result);
    }
}
