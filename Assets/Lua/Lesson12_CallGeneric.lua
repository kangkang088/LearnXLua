local obj = CS.Lesson12()

local child = CS.Lesson12.TestChild()
local father = CS.Lesson12.TestFather()

obj:TestFun1(child, father)
obj:TestFun1(father, child)

--obj:TestFun2(child)

--obj:TestFun3()

--obj:TestFun4(child)

--得到泛型函数
local testFunc2 = xlua.get_generic_method(CS.Lesson12, "TestFun2")
--指明泛型函数的类型
local testFunc2_Really = testFunc2(CS.System.Int32)
--调用泛型函数
--成员方法，第一个传调用对象
testFunc2_Really(obj, 1)
