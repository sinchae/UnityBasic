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
        // 필요한 동작을 여기에 작성하세요.
    }

    public void eatBear()
    {
        Txt_Text.text = "나는 헬스 농담곰.";
    }
}
