using UnityEngine;

public class WanderScript : MonoBehaviour
{
    [SerializeField] GameObject[] targetPoints;
    private Vector3 initialScale;
    Vector3 target;

    void Start()
    {
        targetPoints = GameObject.FindGameObjectsWithTag("POI");

        // Record the initial scale of the pet
        initialScale = transform.localScale;
        int idx = Random.Range(0, targetPoints.Length);
        target = targetPoints[idx].transform.position;
        //transform.position = target;
        // Start wandering
        // Wander();
    }

    void Update()
    {
        // Move the pet towards the target point
        if(Vector3.Distance(transform.position, target) <= .3f)
        {
            Debug.Log("Done Wandering");
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 1.5f);
        }
    }

    public void wander()
    {
        // Randomly select a position within the wander radius
        int idx = Random.Range(0, targetPoints.Length);
        target = targetPoints[idx].transform.position;


        
    }
}
