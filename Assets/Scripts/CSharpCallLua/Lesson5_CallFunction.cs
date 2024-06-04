using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XLua;

//无参无返回值
public delegate void CustomCall();
//有参有返回
[CSharpCallLua]
public delegate int CustomCall2(int a);
//多返回值
[CSharpCallLua]
public delegate int CustomCall3(int a,out int b,out bool c,out string d,out int e);
[CSharpCallLua]
public delegate int CustomCall4(int a,ref int b,ref bool c,ref string d,ref int e);
//变长参数
[CSharpCallLua]
public delegate void CustomCall5(string a,params object[] objs);
public class Lesson5_CallFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");

        CustomCall5 call5 = LuaMgr.GetInstance().Global.Get<CustomCall5>("TestFunc4");
        call5("123",1,2,3,4,5,615,18,8,9,4,9);
        LuaFunction lf5 = LuaMgr.GetInstance().Global.Get<LuaFunction>("TestFunc4");
        lf5.Call("123",10,11,12,13,14);

        LuaFunction lf3 = LuaMgr.GetInstance().Global.Get<LuaFunction>("TestFunc3");
        object[] objects = lf3.Call(1000);
        for(int i = 0;i < objects.Length;i++) {
            print(objects[i]);
        }

        CustomCall4 call4 = LuaMgr.GetInstance().Global.Get<CustomCall4>("TestFunc3");
        int b1 = 0;
        bool c1 = false;
        string d1 = "";
        int e1 = 0;
        print("多返回值-第一个返回值：" + call4(200,ref b1,ref c1,ref d1,ref e1));
        print("多返回值-第二个返回值：" + b1);
        print("多返回值-第三个返回值：" + c1);
        print("多返回值-第四个返回值：" + d1);
        print("多返回值-第五个返回值：" + e1);

        CustomCall3 call3 = LuaMgr.GetInstance().Global.Get<CustomCall3>("TestFunc3");
        int b;
        bool c;
        string d;
        int e;
        print("多返回值-第一个返回值：" + call3(100,out b,out c,out d,out e));
        print("多返回值-第二个返回值：" + b);
        print("多返回值-第三个返回值：" + c);
        print("多返回值-第四个返回值：" + d);
        print("多返回值-第五个返回值：" + e);


        CustomCall2 call2 = LuaMgr.GetInstance().Global.Get<CustomCall2>("TestFunc2");
        print("有参有返回值" + call2(5));
        Func<int,int> action2 = LuaMgr.GetInstance().Global.Get<Func<int,int>>("TestFunc2");
        print(action2(2));
        LuaFunction lf2 = LuaMgr.GetInstance().Global.Get<LuaFunction>("TestFunc2");
        print(lf2.Call(10)[0]);


        CustomCall call = LuaMgr.GetInstance().Global.Get<CustomCall>("TestFunc");
        call();
        UnityAction ua = LuaMgr.GetInstance().Global.Get<UnityAction>("TestFunc");
        ua();
        Action action = LuaMgr.GetInstance().Global.Get<Action>("TestFunc");
        action();
        LuaFunction lf = LuaMgr.GetInstance().Global.Get<LuaFunction>("TestFunc");
        lf.Call();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
