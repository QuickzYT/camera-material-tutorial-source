using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotation = new Vector3(0f, 1f, 0f);

    [SerializeField]
    private float speed = 25f;

    private void Update()
    {
        transform.RotateAround(
            transform.position,
            rotation,
            speed * Time.deltaTime);
    }
}
