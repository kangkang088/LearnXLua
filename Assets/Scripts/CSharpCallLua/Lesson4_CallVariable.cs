using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_CallVariable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");

        int a = LuaMgr.GetInstance().Global.Get<int>("TestNumber");
        print(a);
        LuaMgr.GetInstance().Global.Set("TestNumber",15);
        print(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
