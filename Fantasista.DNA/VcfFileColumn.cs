﻿namespace Fantasista.DNA;

public class VcfFileColumn(string columnName, int index)
{
    public string ColumnName { get; set; } = columnName;
    public int Index { get; set; } = index;
}