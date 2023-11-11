using UnityEngine;

public class PetInteraction : MonoBehaviour
{
    [SerializeField] GameObject heartParticles;

    private float petDuration = 2.0f; // Adjust the duration of the petting
    private float petTimer = 0.0f;
    private bool isBeingPetted = false;

    private void Update()
    {
        // Check if the player clicked the mouse
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hitInfo.collider && hitInfo.collider.gameObject == gameObject)
            {
                Instantiate(heartParticles, transform.position, Quaternion.identity);
            }

        }
    }

}
