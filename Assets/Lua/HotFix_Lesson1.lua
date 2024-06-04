print("first")

xlua.hotfix(CS.HotFixMain, "Add", function(self, a, b)
    return a + b
end)

xlua.hotfix(CS.HotFixMain,"Speak",function (a)
    print(a)
end)
