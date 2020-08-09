using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{
    public GameObject other;

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            //Destroy(other);
            //Destroy(GetComponent<MeshRenderer>()); // 메쉬 렌더러만 파괴
            Destroy(gameObject, 3f);  // 3초후에 파괴
        }
    }
}
