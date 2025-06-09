using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test3array : MonoBehaviour
{
    string[] character = { "신채현", "최현석", "박재완", "이호범", "안정환", "정승원", "조형민" };
    List<string> characterList = new List<string>();
    public TextMeshProUGUI Textname;

    private void Start()
    {
        characterList.Add("신채현");
        characterList.Add("최현석");
        characterList.Add("박재완");
        characterList.Add("이호범");
        characterList.Add("안정환");
        characterList.Add("정승원");
        characterList.Add("조형민");

    }
    public void ArrayGacha() //characterList. 
    {
        int randomValue = Random.Range(0, character.Length);

        Debug.Log("범인은? " + character[randomValue] + "님 이었습니다."); // 7, 0~6 ?
        Textname.text = ("범인은? " + character[randomValue] + "님 이었습니다.") ;
    }
    public void AddList()
    {

    }
}