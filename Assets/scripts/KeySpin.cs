using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   public float rotationSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0f, 0f,
                                rotationSpeed * Time.deltaTime);
    }
}
