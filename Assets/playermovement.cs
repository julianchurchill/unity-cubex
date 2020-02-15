using UnityEngine;
using UnityEngine.Networking;

public class playermovement : NetworkBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        if(!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        var move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
