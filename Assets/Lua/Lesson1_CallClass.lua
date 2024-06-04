--浪费性能，效率低
local obj1 = CS.UnityEngine.GameObject()
local obj2 = CS.UnityEngine.GameObject("Cube")

--节约性能的方式
GameObject = CS.UnityEngine.GameObject
local obj3 = GameObject("KangKang")

local obj4 = GameObject.Find("KangKang")

print(obj4.transform.position)
CS.UnityEngine.Debug.Log(obj4.transform.position)

Vector3 = CS.UnityEngine.Vector3
obj4.transform:Translate(Vector3.right)
CS.UnityEngine.Debug.Log(obj4.transform.position)

local t1 = CS.Test1()
t1:Speak("说话")
local t2 = CS.MrTang.Test2()
t2:Speak("说话")

local obj5 = GameObject("加脚本测试")
--xlua提供的重要方法：typeof
--xlua不支持无参泛型函数，所以要使用另一个重载
obj5:AddComponent(typeof(CS.LuaCallCSharp))
