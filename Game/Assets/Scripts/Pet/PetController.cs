using UnityEngine;

public enum PetState
{
    Idle,       // Default state
    Wander,
    Sleep,
    Play,
    Eat,
    Drink,
    AskForAttention,
    RandomActivity
}

public class PetController : MonoBehaviour
{
    [SerializeField] float hungerThreshold = 0.6f;
    [SerializeField] float thirstThreshold = 0.6f;
    [SerializeField] float boredomThreshold = 0.7f;

    public PetState currentState{ get; private set; }
    private float timeSinceLastStateChange;
    private float stateChangeInterval = 10f; // Time between state changes (you can adjust this)

    private void Start()
    {
        ChangeState(PetState.Idle);
    }

    private void Update()
    {
        timeSinceLastStateChange += Time.deltaTime;

        // Check for state transitions based on time and needs
        if (timeSinceLastStateChange >= stateChangeInterval || NeedsRequireAction())
        {
            ChooseNextState();
        }

        handle_state();
    }

    private void handle_state()
    {
        switch (currentState)
        {
            case PetState.Wander:
                // Implement wandering behavior
                break;
            case PetState.Sleep:
                // Implement sleeping behavior
                break;
            case PetState.Play:
                // Implement playing behavior
                break;
            case PetState.Eat:
                // Implement eating behavior
                break;
            case PetState.Drink:
                // Implement drinking behavior
                break;
            case PetState.AskForAttention:
                // Implement asking for attention behavior
                break;
            case PetState.RandomActivity:
                // Implement random activities
                break;
            default:
                // Handle any other states here
                break;
        }
    }

    private bool NeedsRequireAction()
    {
        // Implement logic to check if the pet's needs require action.
        // For example, check if hunger, thirst, or boredom is above certain thresholds.
        // Return true if action is needed.
        // You can access these values from your needs system.
        return false; // Replace with your logic
    }

    private void ChooseNextState()
    {
        // Implement the logic for choosing the next state based on priorities, randomness, and needs.
        // You can use a switch statement or if-else conditions to make the decision.
        // For simplicity, this example uses random states.
        PetState nextState = (PetState)Random.Range(1, System.Enum.GetValues(typeof(PetState)).Length);

        ChangeState(nextState);
    }

    private void ChangeState(PetState newState)
    {
        // Implement the logic to change the pet's state, trigger animations, and perform any necessary actions.
        currentState = newState;
        timeSinceLastStateChange = 0f;
    }
}
