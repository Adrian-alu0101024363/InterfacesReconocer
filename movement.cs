using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
  private Vector3 PlayerMovementInput;
  [SerializeField] private Rigidbody PlayerBody;
  [SerializeField] public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        bool right = Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.A);
        bool down = Input.GetKey(KeyCode.S);
        bool up = Input.GetKey(KeyCode.W);
        if (right || left || down || up) {
          Debug.Log("Moving");
          MovePlayer();
        }
    }
    private void MovePlayer() {
      Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
      PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);
    }
}
