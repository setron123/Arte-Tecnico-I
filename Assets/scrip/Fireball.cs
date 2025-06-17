using UnityEngine;



[RequireComponent(typeof(Rigidbody))]
public class Fireball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] GameObject explicion;
    [SerializeField] Transform poitExpotion;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        Vector2 Impul = transform.up * speed;
        rb.AddForce(Impul, ForceMode.Impulse);
    }
    private void OnDisable()
    {
        rb.linearVelocity = Vector2.zero;
    }
    private void OnCollisionEnter(Collision collision)
    {
        explicion.transform.position = poitExpotion.position;
        explicion.SetActive(true);
        gameObject.SetActive(false);
    }
}
