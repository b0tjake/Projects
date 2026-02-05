using UnityEngine;

public class PushZone : MonoBehaviour
{
    public Vector3 pushDirection = new Vector3(10f,0,0);

    private void OnTriggerStay(Collider other){
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if(rb != null)
        {
            rb.AddForce(pushDirection, ForceMode.Acceleration);
        }
    }
}
