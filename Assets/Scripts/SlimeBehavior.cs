using UnityEngine;
using UnityEngine.UIElements;

public class SlimeBehavior : MonoBehaviour
{
    public Camera mainCam;
    private float _minX, _minY, _maxX, _maxY;
    public float boundX = 5.58222246f;
    public float boundY = 3.14000034f;
    
    void Start()
    {
        transform.Rotate(Vector3.forward * Random.Range(-180.0f, 180.0f));
        _minX = -boundX;
        _minY = -boundY;
        _maxX = boundX;
        _maxY = boundY;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, 0.003f, 0);
        transform.position += transform.up * Time.deltaTime;

        // if slime is on the side of the screen
        ManageSide();

    }

    void ManageSide()
    {
        if (transform.position.x < _minX || 
            transform.position.x > _maxX ||
            transform.position.y < _minY ||
            transform.position.y > _maxY)
        {
            float nextDir = Random.Range(0.0f, 180.0f) + 90.0f;
            transform.Rotate(Vector3.forward * nextDir);
        }
    }
}
