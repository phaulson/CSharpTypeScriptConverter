﻿namespace TypeScriptModelGeneratorConsoleApplication.Input.Base;

public class BaseEntity<TKey>
{
    public TKey Id { get; set; } = default!;
}