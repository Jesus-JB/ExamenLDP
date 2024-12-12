using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidad del jugador
    private SpriteRenderer spriteRenderer;
    public Sprite rightSprite, leftSprite, idleSprite;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            spriteRenderer.sprite = rightSprite; // Cambia sprite
        }
        else if (horizontal < 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            spriteRenderer.sprite = leftSprite; // Cambia sprite
        }
        else
        {
            spriteRenderer.sprite = idleSprite; // Sprite de reposo
        }
    }
}
