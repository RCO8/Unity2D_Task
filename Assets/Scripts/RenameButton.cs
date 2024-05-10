using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenameButton : MonoBehaviour
{
    [SerializeField] InputField inputName;
    [SerializeField] PlayerControll pc;
    public void ApplyRename()   //변경한 이름 적용
    {
        if (inputName.text.Length >=2 && inputName.text.Length <= 10)
        {
            pc.CanMove = true;
            GameManager.Instance.userName = inputName.text;
            pc.SetName(GameManager.Instance.userName);
            gameObject.SetActive(false);
        }
    }

    public void ApplyCharacter(int idx)
    {
        pc.CanMove = true;
        GameManager.Instance.SetCharacter(idx);
        pc.SetCharacter(GameManager.Instance.GetCharacters());
    }
}
