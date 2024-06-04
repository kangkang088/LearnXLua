xlua.hotfix(CS.HotfixTest2(CS.System.String), {
    Test = function(self,str)
        print("Lua中的补丁string" .. str)
    end
})
xlua.hotfix(CS.HotfixTest2(CS.System.Int32), {
    Test = function(self,str)
        print("Lua中的补丁int" .. str)
    end
})
