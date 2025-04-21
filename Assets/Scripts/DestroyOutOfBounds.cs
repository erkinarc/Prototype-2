using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30f;
    private float lowerBound = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes beyond the top boundary, destroy it
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}