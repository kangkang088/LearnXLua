local obj = CS.Lesson6()

print(obj:Calc())
print(obj:Calc(15, 1))

print(obj:Calc(10))
print(obj:Calc(10.2))

--得到相关函数的信息
local m1 = typeof(CS.Lesson6):GetMethod("Calc", { typeof(CS.System.Int32) })
local m2 = typeof(CS.Lesson6):GetMethod("Calc", { typeof(CS.System.Single) })

--根据得到的C#的函数信息，转换成Lua中的函数
local f1 = xlua.tofunction(m1)
local f2 = xlua.tofunction(m2)

--成员方法，需要第一个参数把调用对象传入进去
print(f1(obj, 5))
print(f2(obj, 5.2))
