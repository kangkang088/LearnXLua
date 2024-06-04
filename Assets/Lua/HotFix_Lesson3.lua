util = require("xlua.util")

xlua.hotfix(CS.HotFixMain, {
    TestCoroutine = function(self)
        return util.cs_generator(function()
            while true do
                coroutine.yield(CS.UnityEngine.WaitForSeconds(1))
                print("Lua打补丁的协程")
            end
        end)
    end
})
