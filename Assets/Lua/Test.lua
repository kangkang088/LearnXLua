print("Test.lua")
TestNumber = 1
TestBool = true
TestFloat = 1.2
TestString = "123"

TestFunc = function()
    print("无参无返回值")
end

TestFunc2 = function(a)
    print("有参有返回值")
    return a + 1
end

TestFunc3 = function(a)
    print("多返回值")
    return 1, 2, false, "123", a
end

TestFunc4 = function(a, ...)
    print("变长参数")
    print(a)
    agr = { ... }
    for key, value in pairs(agr) do
        print(key, value)
    end
end

--List
TestList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
TestList2 = { "123", "123", true, 1, 1.2 }
--Dictionary
TestDic = {
    ["1"] = 1,
    ["2"] = 2,
    ["3"] = 3,
    ["4"] = 4,
}
TestDic2 = {
    ["1"] = 1,
    [true] = 1,
    [false] = true,
    ["123"] = false,
}

TestClass = {
    testInt = 2,
    testBool = true,
    testFloat = 1.2,
    testString = "123",
    testFunc = function()
        print("123123123")
    end
}
