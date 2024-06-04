Lesson5 = CS.Lesson5

local obj = Lesson5()
--a函数返回值
--b第一个ref
--c第二个ref
--ref参数需要传入默认值，作为占位
local a, b, c = obj:RefFun(1, 0, 0, 1)
print(a)
print(b)
print(c)

local a, b, c = obj:OutFun(20, 30)
print(a)
print(b)
print(c)

local a, b, c = obj:RefOutFun(20, 1)
print(a)
print(b)
print(c)
