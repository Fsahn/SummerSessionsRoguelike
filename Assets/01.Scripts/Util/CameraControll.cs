using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField] private Transform _followTarget;
    public bool IsMoveRestricted = false;

    private Vector3 _targetPosition, _shakeOffset;

    private void Update()
    {
        if (IsMoveRestricted) RestrictMove();
        else Follow();

        transform.position = _targetPosition + _shakeOffset;
    }

    public void Shake(float time, float force)
    {
        // ī�޶� ����ũ ���� ���� _shakeOffset ������ ����ũ �̵��� �ֱ�
    }

    public void Follow()
    {
        // _followTarget ���󰡴� �ڵ� ����, transform.position�� �������� ���� _targetPosition�� ������ ��
    }

    public void RestrictMove()
    {
        // �̵� ���� �ڵ�
    }
}
