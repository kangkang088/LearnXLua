using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6_CallListDic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");

        List<int> list = LuaMgr.GetInstance().Global.Get<List<int>>("TestList");
        foreach(int item in list) {
            print(item);
        }
        List<object> list2 = LuaMgr.GetInstance().Global.Get<List<object>>("TestList2");
        foreach(var item in list2) {
            print(item);
        }

        Dictionary<string,int> dic = LuaMgr.GetInstance().Global.Get<Dictionary<string,int>>("TestDic");
        foreach(string item in dic.Keys) {
            print(item + "__" + dic[item]);
        }

        Dictionary<object,object> dic2 = LuaMgr.GetInstance().Global.Get<Dictionary<object,object>>("TestDic2");
        foreach(object item in dic2.Keys) {
            print(item + "__" + dic2[item]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
