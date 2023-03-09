using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllor : MonoBehaviour
{
    // �ڷ�ƾ �Լ� ����
    IEnumerator Start()
    {
        Camera camera = Camera.main;
        // ī�޶��� ���� ����.
        Vector3 offset = new Vector3(0.15f, 0.15f, 0.0f);
        Vector3 oldPos = camera.transform.position;
        // ī�޶��� ���� �ð�.
        float shokeTime = 0.15f;

        // �ݺ����� ����Ǵ� ���� �ݺ������� ȣ��
        while (shokeTime > 0.0f)
        {
            shokeTime -= Time.deltaTime;
            yield return null;

            // ī�޶� ���� ���� ��ŭ ������Ų��.
            camera.transform.position = new Vector3(
                Random.Range(oldPos.x - offset.x, oldPos.x + offset.x),
                Random.Range(oldPos.y - offset.y, oldPos.y + offset.y),
                -10.0f);
        }

        // �ݺ����� ����Ǹ� ī�޶� ��ġ�� �ٽ� ������ ���´�.
        camera.transform.position = oldPos;
        // ī�޶� Ŭ������ �����Ѵ�.
        Destroy(this.gameObject);
    }
}