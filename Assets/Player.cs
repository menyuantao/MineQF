using QFramework;
using UnityEngine;

public class Player : MonoBehaviour, IController
{
    public Transform playerModel;
    private void Update()
    {
        Move();
    }
    public IArchitecture GetArchitecture()
    {
        return Manager.Interface;
    }
    
    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerModel.position += new Vector3(0, 0, 1);
            this.SendCommand<PlayerControl>();
        }
    }
}
