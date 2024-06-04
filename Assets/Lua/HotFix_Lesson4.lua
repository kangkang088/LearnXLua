xlua.hotfix(CS.HotFixMain, {
    set_Age = function(self, v)
        print("Lua重定向的属性" .. v)
    end,
    get_Age = function(self)
        return 10
    end,
    set_Item = function(self, index, v)
        print("Lua重定向索引器,索引：" .. index .. "值：" .. v)
    end,
    get_Item = function(self, index)
        print("Lua重定向索引器,索引："..index)
        return 999
    end
})
