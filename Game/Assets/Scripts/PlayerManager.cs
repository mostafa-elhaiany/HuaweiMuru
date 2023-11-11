using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float playerLevel = 0.0f;
    [SerializeField] float strengthMultiplier = 1.0f;  // Adjust the impact of pet's strength on the player's level
    [SerializeField] float happinessMultiplier = 1.0f; // Adjust the impact of pet's happiness on the player's level

    private void Start()
    {
        // Initialize the player's level
        playerLevel = 0.0f;
    }

    public void UpdatePlayerLevel(float petStrength, float petHappiness)
    {
        // Calculate the player's level based on the pet's strength and happiness
        playerLevel = (petStrength * strengthMultiplier + petHappiness * happinessMultiplier);

        // Ensure the player's level stays within a certain range (e.g., 0 to 100)
        playerLevel = Mathf.Clamp(playerLevel, 0.0f, 100.0f);

        // You can also update other game elements or UI based on the player's level
    }
}
