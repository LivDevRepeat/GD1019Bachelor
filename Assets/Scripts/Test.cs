using UnityEngine;
using UnityEngine.Serialization;

public class ScrollingBackground : MonoBehaviour
{
    public float backgroundSize;
    public float speed;
    public bool isObjectOne;

    private Vector3 startPos;
    private float newPosition;




    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position + Vector3.back * -1 * backgroundSize / 2;
    }

    // Update is called once per frame
    void Update()
    {
   
        newPosition = Mathf.Repeat(Time.time * speed-backgroundSize*(isObjectOne?0:0.5f), backgroundSize);
        transform.position = startPos + Vector3.back * newPosition;
    }
}