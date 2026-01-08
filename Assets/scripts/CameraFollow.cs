using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform toFollow;
    public float zOff;
    public float yOff;
    public float slew;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = toFollow.position - toFollow.forward * zOff;
        newPosition.y += yOff;
        this.transform.position = newPosition;

        //update rotation of camera to look at toFollow gameobject
        Quaternion newRotation = Quaternion.LookRotation(toFollow.position - this.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newRotation, slew);
    }
}
