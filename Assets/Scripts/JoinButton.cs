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
            Debug.Log("입력 오류");
        else
        {
            //Debug.Log(inputName.text);
            GameManager.Instance.userName = inputName.text;
            //게임씬으로 들어가도록
            SceneManager.LoadScene("SampleScene");
            DontDestroyOnLoad(gameManager);
        }
    }
}
