xlua.hotfix(CS.HotFixMain, {
    add_myEvent = function(self, del)
        del(5)
        print("添加事件函数")
    end,
    remove_myEvent = function(self, del)
        del(5)
        print("移除事件函数")
    end
})
