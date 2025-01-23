using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform door;              // Référence à la porte
    public Vector3 openRotation;        // Rotation pour ouvrir la porte (exemple : 0, 90, 0)
    public Vector3 closedRotation;      // Rotation pour fermer la porte (exemple : 0, 0, 0)
    public float speed = 2f;            // Vitesse d'ouverture/fermeture
    private bool isOpen = false;        // État de la porte (ouverte ou fermée)
    private Quaternion targetRotation;  // Rotation cible
    private bool playerInRange = false; // Le joueur est proche de la porte ?

    void Start()
    {
        // Initialiser la rotation cible en position fermée
        targetRotation = Quaternion.Euler(closedRotation);
    }

    void Update()
    {
        // Animer la rotation de la porte vers la rotation cible
        door.rotation = Quaternion.Lerp(door.rotation, targetRotation, Time.deltaTime * speed);

        // Si le joueur est proche et appuie sur "E", ouvrir ou fermer la porte
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            ToggleDoor();
        }
    }

    public void ToggleDoor()
    {
        // Alterne entre ouvert et fermé
        isOpen = !isOpen;
        targetRotation = isOpen ? Quaternion.Euler(openRotation) : Quaternion.Euler(closedRotation);
    }

    void OnTriggerEnter(Collider other)
    {
        // Vérifie si le joueur entre dans la zone d'interaction
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Vérifie si le joueur sort de la zone d'interaction
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
