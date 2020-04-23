using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Transform transform = other.gameObject.GetComponent<Transform>();

        Debug.Log(transform.position);

        float prevX = transform.position.x;
        float prevZ = transform.position.z;

        if(prevZ < 0 && prevX < 0)
            transform.position = new Vector3(-prevX - 1f, 0.5f, -prevZ - 1f);
        if (prevZ > 0 && prevX < 0)
            transform.position = new Vector3(-prevX - 1f, 0.5f, -prevZ + 1f);
        if (prevZ < 0 && prevX > 0)
            transform.position = new Vector3(-prevX + 1f, 0.5f, -prevZ - 1f);
        if (prevZ > 0 && prevX > 0)
            transform.position = new Vector3(-prevX + 1f, 0.5f, -prevZ + 1f);
        return;
    }

}
