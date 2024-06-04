print("*******多函数替换********")

xlua.hotfix(CS.HotFixMain, {
    Update = function(self)
        print(os.time())
    end,
    Add = function(self, a, b)
        return a + b
    end,
    Speak = function(a)
        print(a)
    end
})

xlua.hotfix(CS.HotfixTest, {
    [".ctor"] = function()
        print("Lua热补丁构造函数")
    end,
    Speak = function(self, a)
        print(a)
    end,
    Finalize = function()

    end
})
