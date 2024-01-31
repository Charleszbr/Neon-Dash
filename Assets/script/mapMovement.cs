
using UnityEngine;

public class mapMovement : MonoBehaviour
{
    public float scrollSpeed = 5f; // Vitesse de défilement du niveau

    void Update()
    {
        // Défilement automatique vers la gauche
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
    }
}