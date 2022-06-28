﻿using CSharpTypeScriptConverter.Attributes;

namespace CSharpTypeScriptConverterConsoleApplication.Input;

public class Role
{
    public string Name { get; set; } = null!;

    [TypeScriptModel(Ignored = true)] 
    public string Hash { get; set; } = null!;
}