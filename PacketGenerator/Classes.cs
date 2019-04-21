using System;
using System.Collections.Generic;

public class Template
{
    public List<Project> Projects = new List<Project>();
    public List<Class> Classes = new List<Class>();
    public List<Enum> Enums = new List<Enum>();
    public List<String> Namespaces = new List<string>();
}

public class Project
{
    public string Name = "";
    public string Desc = "";
}

public class ClassBase
{
    public string Namespace = "";
    public string Name = "";
    public string Desc = "";
    public bool IsEnum = true;
}

public class Class : ClassBase
{
    public List<ClassField> Fields = new List<ClassField>();
    public ushort TypeID = 0;                               // 该值将自增填充
}

public class ClassField
{
    public Class Class = null;
    public string Name = "";
    public Declare Declare = new Declare();
    public string Desc = "";

    public bool Get = false;
    public bool Set = false;
    public object Default = true;

    public Dictionary<ClassField, object> Condation = new Dictionary<ClassField,object>();
}

public class Enum : ClassBase
{
    public List<EnumField> Fields = new List<EnumField>();
    public string Type = "";
    public int Size = 0;        // numBytes
    public bool Unsigned = false;
    // ...
}

public class EnumField
{
    public Enum Enum = null;
    public string Name = "";
    public string Value = "";
    public string Desc = "";
}

public enum DataTypes
{
    BuiltIn,    // 内置 各种整数浮点
    Custom,     // 用户类，枚举
    Generic,    // 泛型
    Array       // 数组
}
public class Declare
{
    public DataTypes DataType;
    public string Name;
    public string Namespace;
    public ClassBase Class;     // 只针对 用户类，枚举
    public int MinLen = 0;
    public int MaxLen = 0;
    public List<Declare> Childs = new List<Declare>();  // 只针对 数组 或 泛型
}
