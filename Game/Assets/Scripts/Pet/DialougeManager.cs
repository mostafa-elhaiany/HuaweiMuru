using UnityEngine;

public class DialougeManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueObject; // Reference to the UI Image for the dialogue sprite
    [SerializeField] GameObject foodSprite;   // Reference to the sprite for food request
    [SerializeField] GameObject waterSprite;  // Reference to the sprite for water request
    [SerializeField] GameObject playSprite;   // Reference to the sprite for play request
    [SerializeField] GameObject attentionSprite; // Reference to the sprite for attention request

    private void Start()
    {
        dialogueObject.SetActive(false);
    }

    public void ShowDialogue(PetState petState)
    {
        // Determine which sprite to show based on the pet's state

        foodSprite.SetActive(petState == PetState.Eat);
        waterSprite.SetActive(petState == PetState.Drink);
        playSprite.SetActive(petState == PetState.Play);
        attentionSprite.SetActive(petState == PetState.AskForAttention);



        dialogueObject.SetActive(petState != PetState.Idle || petState != PetState.RandomActivity);

        // You can also add other logic for showing/hiding the dialogue, such as animations and timers.
    }
}
