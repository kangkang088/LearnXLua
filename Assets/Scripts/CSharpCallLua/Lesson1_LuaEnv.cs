using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class Lesson1_LuaEnv : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaEnv env = new LuaEnv();
        env.DoString("print('hello lua')");
        env.DoString("require('Main')");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
