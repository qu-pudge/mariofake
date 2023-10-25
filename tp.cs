using UnityEngine;

public class tp: MonoBehaviour
{
    public Transform teleportDestination; // Указание на место, куда игрок будет телепортирован

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Телепортируйте игрока в указанное место
            collision.transform.position = teleportDestination.position;
        }
    }
}
