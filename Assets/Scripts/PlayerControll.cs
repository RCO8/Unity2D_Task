using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Animator animator;
    [SerializeField] Text nameText;

    private float movingX;
    private float movingY;

    [SerializeField] private float speed;
    private Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        //animator = GameManager.Instance.animators[]
        nameText.text = GameManager.Instance.GetUserName();

        animator.runtimeAnimatorController = GameManager.Instance.animators[GameManager.Instance.GetCharacters()];
    }

    // Update is called once per frame
    void Update()
    {
        //키보드 이동
        movingX = Input.GetAxisRaw("Horizontal");
        movingY = Input.GetAxisRaw("Vertical");
        Vector2 movePosition = new Vector2(movingX, movingY) * Time.deltaTime;
        transform.Translate(movePosition * speed);

        //마우스 바라보기
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteRenderer.flipX = mousePosition.x < transform.position.x;
    }
}
