GameObject = CS.UnityEngine.GameObject
UI = CS.UnityEngine.UI
local silder = GameObject.Find("Slider")
print(silder)

local silderScript = silder:GetComponent(typeof(UI.Slider))
print(silderScript)

silderScript.onValueChanged:AddListener(function(f)
    print(f)
end)
