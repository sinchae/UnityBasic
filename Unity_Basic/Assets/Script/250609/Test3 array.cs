using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test3array : MonoBehaviour
{
    string[] character = { "��ä��", "������", "�����", "��ȣ��", "����ȯ", "���¿�", "������" };
    List<string> characterList = new List<string>();
    public TextMeshProUGUI Textname;

    private void Start()
    {
        characterList.Add("��ä��");
        characterList.Add("������");
        characterList.Add("�����");
        characterList.Add("��ȣ��");
        characterList.Add("����ȯ");
        characterList.Add("���¿�");
        characterList.Add("������");

    }
    public void ArrayGacha() //characterList. 
    {
        int randomValue = Random.Range(0, character.Length);

        Debug.Log("������? " + character[randomValue] + "�� �̾����ϴ�."); // 7, 0~6 ?
        Textname.text = ("������? " + character[randomValue] + "�� �̾����ϴ�.") ;
    }
    public void AddList()
    {

    }
}