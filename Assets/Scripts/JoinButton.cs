using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinButton : MonoBehaviour
{
    [SerializeField] InputField inputName;
    [SerializeField] GameObject gameManager;
    public void EnterGame()
    {
        if (inputName.text.Length > 10 || inputName.text.Length < 2)
            Debug.Log("�Է� ����");
        else
        {
            //Debug.Log(inputName.text);
            GameManager.Instance.userName = inputName.text;
            //���Ӿ����� ������
            SceneManager.LoadScene("SampleScene");
            DontDestroyOnLoad(gameManager);
        }
    }
}
