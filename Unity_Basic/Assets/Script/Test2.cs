using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;

    public void workBear()
    {
        // �ʿ��� ������ ���⿡ �ۼ��ϼ���.
    }

    public void eatBear()
    {
        Txt_Text.text = "���� �ｺ ����.";
    }
}
