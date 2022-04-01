using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private float mouseX, mouseY;//鼠标旋转轴
    public float mouseSensitivity;//鼠标灵敏度
    public float xRotation;//防止竖直方向回弹，累加mouseY

    // Update is called once per frame
    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;//返回-1到1之间的浮点数
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;//数值不动时会回弹到0

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -40, 40);//限制上下范围

        player.Rotate(Vector3.up * mouseX);//player左右旋转，Vector3为（0，1，0）
        transform.localRotation = Quaternion.Euler(-mouseY, 0, 0);//相机上下旋转
    }
}
