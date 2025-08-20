using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Attributes")]
    public float velocity = 0.05f; //Velocidad predefinida para el movimiento
    public int rotation = 10; //Cuanto va a rotar el objeto

    //Declaracion de las teclas para poder modificarlas desde el inspector
    [Header("Key bindings")]
    [SerializeField] private KeyCode GoUp;
    [SerializeField] private KeyCode GoDown;
    [SerializeField] private KeyCode GoLeft;
    [SerializeField] private KeyCode GoRight;
    [SerializeField] private KeyCode RotateRight;
    [SerializeField] private KeyCode RotateLeft;
    [SerializeField] private KeyCode ChangeColor;

    void Update()
    {

        PlayerMove();
        PlayerRotate();
        PlayerChangeColor();

    }

    private void PlayerMove()
    {

        if (Input.GetKey(GoUp)) //Moverse arriba
        {
            transform.position = transform.position + new Vector3(0, velocity, 0);
        }

        if (Input.GetKey(GoDown)) //Moverse abajo
        {
            transform.position = transform.position + new Vector3(0, -velocity, 0);
        }

        if (Input.GetKey(GoLeft)) //Moverse a la izquierda
        {
            transform.position = transform.position + new Vector3(-velocity, 0, 0);
        }

        if (Input.GetKey(GoRight)) //Moverse a la derecha
        {
            transform.position = transform.position + new Vector3(velocity, 0, 0);
        }

    }

    private void PlayerRotate()
    {

        if (Input.GetKeyDown(RotateRight)) //Rotar a la derecha 10°
        {
            transform.Rotate(0, 0, rotation);
        }

        if (Input.GetKeyDown(RotateLeft)) //Rotar a la izquierda 10°
        {
            transform.Rotate(0, 0, -rotation);
        }

    }

    private void PlayerChangeColor()
    {

        if (Input.GetKeyUp(ChangeColor)) //Cambiar a un color random
        {
            GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        }

    }

}
