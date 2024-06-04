print("主Lua脚本启动")
--require("Test")
--判空全局函数
function IsNull(obj)
    if obj == nil or obj:Equals(nil) then
        return true
    end
end

--require("Lesson12_CallGeneric")

require("HotFix_Lesson6")
