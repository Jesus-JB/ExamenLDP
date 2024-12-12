using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public int livesLost = 0; // Contador de objetos perdidos
    public int maxLives = 5; // Número máximo de vidas antes de perder

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FallingObject"))
        {
            Destroy(collision.gameObject);
            livesLost++;

            Debug.Log("Objeto perdido. Objetos perdidos: " + livesLost);

            // Verificar si el jugador ha perdido
            if (livesLost >= maxLives)
            {
                Debug.Log("¡Has perdido el juego!");
                // Aquí puedes añadir lógica para detener el juego o mostrar una pantalla de "Game Over"
            }
        }
    }
}
