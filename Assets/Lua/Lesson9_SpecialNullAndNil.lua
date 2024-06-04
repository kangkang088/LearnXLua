--往场景对象上添加一个脚本，如果存在，不加。
GameObject = CS.UnityEngine.GameObject
Rigidbody = CS.UnityEngine.Rigidbody

local obj = GameObject("测试加脚本")

local rig = obj:GetComponent(typeof(Rigidbody))
print(rig)
if rig:IsNull() then
    print("进来判空了吗")
    rig = obj:AddComponent(typeof(Rigidbody))
end
print(rig)
