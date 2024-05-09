using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterButton : MonoBehaviour
{
    public Image charImg;
    public Sprite[] charSpr;

    public void SelectCharacter(int idx)
    {
        GameManager.Instance.SetCharacter(idx);
        charImg.sprite = charSpr[idx];
    }
}
