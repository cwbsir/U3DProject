using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//从摄像机发出到点击坐标的射线
            Debug.Log("RayTest Update");
            RaycastHit hitInfo;
            if(Physics.Raycast(ray,out hitInfo))
            {
                Debug.DrawLine(ray.origin,hitInfo.point);//scene視圖可看到 DrawLine(Vector3 origin,Vector3 end,Color col):衹有儅發生碰撞時，在Scene視圖才可以看到畫出的射綫。

                GameObject Obj = hitInfo.collider.gameObject;
                Debug.Log("click object name is " + Obj.name);
                //当射线碰撞目标为名字為xx的對象 ，执行以下操作  
                // if(Obj.tag == "xx")
                // { DoSomething.... }
            }
        }
    }
}
