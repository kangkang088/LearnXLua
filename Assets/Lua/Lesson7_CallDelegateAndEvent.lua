local obj = CS.Lesson7()

local fun = function()
    print("Lua函数Fun")
end
obj.del = fun
obj.del = obj.del + fun
obj.del = obj.del + function()
    print("直接加，不声明，不建议这样写")
end

obj.del()


local fun2 = function()
    print("事件加的函数")
end
obj:eventAction("+", fun2)
obj:eventAction("+", fun2)
obj:eventAction("+",function ()
    print("不建议使用的格式")
end)
obj:eventAction("-",fun2)
obj:ClearEvent()
obj:DoEvent()