using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour

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
*/
{
    int count;

    private void Awake()
    {
        count = 0;
    }

    void Start()
    {


    }
/*
    public void Gacha()
    {
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!

        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        Debug.Log($"������ ���� : {randomValue} �Դϴ�");
        // count 81
        if (8 <= count)
        {
            Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'��û'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'��'�� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
        }

        count++;
    }
*/
    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // �Ⱦ� ĳ�� : �̹� �̱⿡ Ȯ���� ����  �����Ǵ� ĳ����
                        // �������� Ư�� ĳ���͸� ��ǥ�ϰ� �̰� ����� �ý���
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;
        }
    }
}