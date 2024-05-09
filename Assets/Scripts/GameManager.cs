using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum Characters { Elf, Knight, Wizzard };

    public static GameManager Instance;

    string userName;    //����� �̸�
    Characters myChar;  //���� ĳ����

    public AnimatorController[] animators;    //��������Ʈ�� �����ϱ� ���� �ִϸ�����

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }

    private void Start()
    {
        Debug.Log(userName);
    }

    public void SetUserName(string name) => userName = name;
    public string GetUserName() => userName;

    public void SetCharacter(int idx) => myChar = (Characters)idx;
    public int GetCharacters() => (int)myChar;
}
