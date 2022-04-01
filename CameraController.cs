using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private float mouseX, mouseY;//�����ת��
    public float mouseSensitivity;//���������
    public float xRotation;//��ֹ��ֱ����ص����ۼ�mouseY

    // Update is called once per frame
    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;//����-1��1֮��ĸ�����
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;//��ֵ����ʱ��ص���0

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -40, 40);//�������·�Χ

        player.Rotate(Vector3.up * mouseX);//player������ת
        transform.localRotation = Quaternion.Euler(-mouseY, 0, 0);//���������ת
    }
}
