using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string name = "신채현";
    private int age = 25;
    private int height = 158;
    private string bloodType = "AB형";
    private string mbti = "ESTJ";
    private string hobby = "K-pop 음악 듣기";
    private string favoriteFood = "연어";
    private string favoriteGame = "스플래툰";
    private string desiredJob = "개발 PM";
    void Start()
    {
        SelfIntroduction();
    }

    public void SelfIntroduction()
    {
        Debug.Log($"제 이름은 {name}입니다.");
        Debug.Log($"저의 나이는 {age}세입니다.");
        Debug.Log($"키는 {height}cm입니다.");
        Debug.Log($"혈액형은 {bloodType}입니다.");
        Debug.Log($"MBTI는 {mbti}입니다.");
        Debug.Log($"취미는 {hobby}입니다.");
        Debug.Log($"좋아하는 음식은 {favoriteFood}입니다.");
        Debug.Log($"최애 게임은 {favoriteGame}입니다.");
        Debug.Log($"희망 직군은 {desiredJob}입니다.");
    }
}