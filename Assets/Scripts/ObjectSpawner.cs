using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] fallingObjects; // Lista de prefabs de objetos
    public Transform player; // Referencia al jugador
    public float spawnInterval = 2f; // Intervalo de generación
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0;
        }
    }

    void SpawnObject()
    {
        // Seleccionar un prefab aleatoriamente de la lista
        int randomIndex = Random.Range(0, fallingObjects.Length);
        GameObject selectedObject = fallingObjects[randomIndex];

        // Generar el objeto en una posición cerca de la posición del jugador
        float offsetX = Random.Range(-2f, 2f); // Desviación aleatoria en X para dar variedad
        Vector3 spawnPosition = new Vector3(player.position.x + offsetX, 6f, 0);

        // Instanciar el objeto en la escena
        Instantiate(selectedObject, spawnPosition, Quaternion.identity);
    }
}
