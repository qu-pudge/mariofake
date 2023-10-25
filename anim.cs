using UnityEngine;

public class anim : MonoBehaviour
{
    public Sprite spriteJump;
    public Sprite spriteLeft;
    public Sprite spriteRight;
    public Sprite spriteIdle; // Спрайт для состояния покоя

    private SpriteRenderer spriteRenderer;
    private bool isJumping = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput < 0)
        {
            // Персонаж двигается влево
            spriteRenderer.sprite = spriteLeft;
        }
        else if (horizontalInput > 0)
        {
            // Персонаж двигается вправо
            spriteRenderer.sprite = spriteRight;
        }
        else if (isJumping)
        {
            // Персонаж в состоянии прыжка
            spriteRenderer.sprite = spriteJump;
        }
        else
        {
            // Персонаж в состоянии покоя
            spriteRenderer.sprite = spriteIdle;
        }

        // Управление состоянием прыжка
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
}
