using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum Characters { Elf, Knight, Wizzard };

    public static GameManager Instance;

    public string userName { get; set; }    //사용자 이름
    Characters myChar = Characters.Knight;  //현재 캐릭터

    public AnimatorController[] animators;    //스프라이트에 적용하기 위한 애니메이터

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(Instance);
        // Instance가 이미 있다면 자신을 파괴
    }

    private void Start()
    {
        Debug.Log(userName);
    }

    public void SetCharacter(int idx) => myChar = (Characters)idx;
    public int GetCharacters() => (int)myChar;
}
