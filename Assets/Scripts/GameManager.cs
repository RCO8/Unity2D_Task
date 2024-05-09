using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum Characters { Elf, Knight, Wizzard };

    public static GameManager Instance;

    string userName;    //사용자 이름
    Characters myChar;  //현재 캐릭터

    public AnimatorController[] animators;    //스프라이트에 적용하기 위한 애니메이터

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
