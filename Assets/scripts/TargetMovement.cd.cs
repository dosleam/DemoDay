using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float speed = 2f; // Vitesse de déplacement
    public float range = 2f; // Distance de mouvement de chaque côté
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; // Sauvegarde la position initiale
    }

    void Update()
    {
        // Calcule le déplacement horizontal (gauche-droite)
        float offset = Mathf.PingPong(Time.time * speed, range * 2) - range;
        transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z + offset);
    }
}
