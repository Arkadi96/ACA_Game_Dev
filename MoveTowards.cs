using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveTowards : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectTo;
    [SerializeField]
    [Range(0.1f, 1.0f)]
    private float speed = 0.5f;
    [HideInInspector]
    private Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, gameObjectTo.transform.position, speed * Time.deltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == gameObject.tag)
        {
            transform.position = startPosition;
        }
    }
}
