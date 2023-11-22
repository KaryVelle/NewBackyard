using UnityEngine;

public class Recolectable : MonoBehaviour
{
    public float rotationSpeed = 3; 
    public float floatSpeed = 1;   
    public float floatHeight =1;   
    private Vector3 _startPos;

    void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        float newY = _startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}