using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starmaker : MonoBehaviour
{
    // 1. string.Empty
    // string 변수의 값을 초기화 합니다.
    /*
    string star;
    star = string.Empty;
        */

    // 2. 별, 빈칸, 줄바꿈 추가하기
    // Debug.Log를 사용하여 콘솔창에 출력합니다
    /*
    star += "★"; // 별
    star += "　"; // 빈칸
    star += "\n"; // 줄바꿈
    */
    // 3. Debug.Log("");
    // Debug.Log를 사용하여 콘솔창에 출력합니다



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

        // 페이즈 1
        for (int i = 1; i <= 5; i++) // 줄 수: 1~5
        {
            for (int j = 1; j <= i; j++) // 각 줄의 별 개수
            {
                star += "★";
            }
            star += "\n"; // 줄바꿈
        }

        Debug.Log(star); // 콘솔에 출력
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        for (int i = 1; i <= 5; i++) // 줄 수
        {
            // 공백 추가: 최대 줄 수 - 현재 줄 수
            for (int j = 1; j <= 5 - i; j++)
            {
                star += "　";
            }

            // 별 추가
            for (int k = 1; k <= i; k++)
            {
                star += "★";
            }

            // 줄바꿈
            star += "\n";
        }


        Debug.Log(star);
    }
    /*
    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4


        Debug.Log(star);
    }
    */

    public void Phase5()
    {
        star = string.Empty;
    
        // 페이즈 5
     int n = 5; //별의 중심
        
        string result = string.Empty; // 문자열 초기화
        //위쪽 삼각형
        for (int i = 1; i < n; i++)
        {
           
            for (int j = 1; j <= n - i; j++)
                result += "　"; // 빈칸

            for (int j = 1; j <= 2 * i - 1; j++)
                result += "★"; // 별
       
            result += "\n"; // 줄바꿈
        }
        // 아래쪽 삼각형
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
                result += "　"; // 빈칸

            for (int j = 1; j <= 2 * i - 1; j++)
                result += "★"; // 별
            result += "\n";
        }

        Debug.Log(result); // 위쪽 삼각형 출력
    }

}// 끝
