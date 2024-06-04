local obj = CS.Lesson3()

print(obj.array.Length)
print(obj.array[0])

for i = 0, obj.array.Length - 1 do
    print(obj.array[i])
end

local array2 = CS.System.Array.CreateInstance(typeof(CS.System.Int32), 10)
print(array2.Length)
print(array2[0])
print(array2[1])

print("************Dictionary************")
print(obj.list.Count)
obj.list:Add(1)
obj.list:Add(2)
obj.list:Add(2)
print(obj.list.Count)
for i = 0, obj.list.Count - 1 do
    print(obj.list[i])
end

local list2 = CS.System.Collections.Generic["List`1[System.String]"]()
print(list2)
list2:Add("123")
print(list2[0])

--先得到List泛型类
local List_String = CS.System.Collections.Generic.List(CS.System.String)
--再实例化
local list3 = List_String()
list3:Add("555555")
print(list3[0])

obj.dic:Add(1, "123")
print(obj.dic[1])

for key, value in pairs(obj.dic) do
    print(key, value)
end

local Dic_String_Vector3 = CS.System.Collections.Generic.Dictionary(CS.System.String, CS.UnityEngine.Vector3)

local dic2 = Dic_String_Vector3()
dic2:Add("123", CS.UnityEngine.Vector3.right)
for key, value in pairs(dic2) do
    print(key, value)
end
print(dic2["123"])
print(dic2:TryGetValue("123"))
print(dic2:get_Item("123"))
dic2:set_Item("123",nil)
print(dic2:get_Item("123"))
