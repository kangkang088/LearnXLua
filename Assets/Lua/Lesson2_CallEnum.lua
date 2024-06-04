--支持取别名
GameObject = CS.UnityEngine.GameObject
PrimitiveType = CS.UnityEngine.PrimitiveType
local obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube)

E_MyEnum = CS.E_MyEnum

local c = E_MyEnum.Idle
print(c)

local a = E_MyEnum.__CastFrom(1)
print(a)
local b = E_MyEnum.__CastFrom("Atk")
print(b)
