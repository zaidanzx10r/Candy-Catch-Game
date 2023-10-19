using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D candyPrefab;
    [SerializeField] private float speed;
    [SerializeField] private float fallSpeed;

    private Vector2 _stayPosition = new Vector2(0, 10);
    
    private Rigidbody2D _rb;

    private Vector3 _moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.GameMode();

        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDirection;
    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        _moveDirection = newDirection;
    }

    public void Candy()
    {
        candyPrefab.position = _stayPosition;

        Rigidbody2D currentCandy = Instantiate(candyPrefab, transform.position, Quaternion.identity);

        currentCandy.AddForce(_stayPosition * fallSpeed, ForceMode2D.Impulse);
    }
}
