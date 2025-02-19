﻿namespace TypeScriptModelGenerator.Data;

internal class TypeInformation
{
    public string Name { get; set; } = null!;
    public bool Optional { get; set; }
    public List<string> PossibleImports { get; set; } = new();
}