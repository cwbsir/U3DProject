setmetatableindex = function(t, index) 
    local mt = getmetatable(t);
    if(not mt)then mt = {}; end
    if(not mt.__index)then
        mt.__index = index;
        setmetatable(t, mt);
    elseif(mt.__index ~= index)then
        setmetatableindex(mt, index);
    end
end

function class(classname, super)
    local cls = {__cname = classname};
 
    cls.super = super;
    cls.__index = cls;
    if(super)then
        setmetatable(cls, {__index = cls.super});
    end

    cls.new = function(_,...)
        local instance;
        instance = {};
        setmetatableindex(instance, cls);
        instance.class = cls;
        if(instance.ctor ~= nil)then
            instance:ctor(...);
        end
        return instance;
    end

    return cls;
end