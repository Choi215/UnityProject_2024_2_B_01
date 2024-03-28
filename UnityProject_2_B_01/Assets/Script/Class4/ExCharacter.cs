using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class ExCharacter : MonoBehaviour
{

    public float speed = 5.0f;
    
    void Update()
    {
        Move();
    }


    // virtual 키워드 상속 받은 클래스에서 재정의 할 수 있음
    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void DestroyCharacter()
    {
        Destroy(gameObject);
    }
}
