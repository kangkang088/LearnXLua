GameObject = CS.UnityEngine.GameObject
WaitForSeconds = CS.UnityEngine.WaitForSeconds

util = require("xlua.util")

local obj = GameObject("Coroutine")
local mono = obj:AddComponent(typeof(CS.LuaCallCSharp))

fun = function()
    local a = 1
    while true do
        coroutine.yield(WaitForSeconds(1))
        print(a)
        a = a + 1
        
    end
end
mono:StartCoroutine(util.cs_generator(fun))
