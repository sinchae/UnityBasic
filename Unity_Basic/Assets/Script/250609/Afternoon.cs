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
        "신채현", "최현석", "박재완", "이호범", "안정환", "정승원", "조형민", "황민서", "백승은", "이민규"
    };

    // 10연차 가챠 실행 - onClick에 연결
    public void classGatcha()
    {
        // 문자열 초기화
        string result = "행운의 10연차 결과 \n";

        // 2) for문으로 10번 뽑기
        for (int i = 0; i < 10; i++)
        {
            int idx = Random.Range(0, characterList.Count);
            // 문자열 덧셈으로 한 줄씩 추가
            result += $"{i + 1}번째: {characterList[idx]}님\n";
        }

        // 메인에 출력
        resultText.text = result;
        Debug.Log(result);
    }
}
