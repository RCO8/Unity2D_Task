using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum Characters { Elf, Knight, Wizzard };

    public static GameManager Instance;

    public string userName { get; set; }    //����� �̸�
    Characters myChar = Characters.Knight;  //���� ĳ����

    public AnimatorController[] animators;    //��������Ʈ�� �����ϱ� ���� �ִϸ�����

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(Instance);
        // Instance�� �̹� �ִٸ� �ڽ��� �ı�
    }

    private void Start()
    {
        Debug.Log(userName);
    }

    public void SetCharacter(int idx) => myChar = (Characters)idx;
    public int GetCharacters() => (int)myChar;
}
