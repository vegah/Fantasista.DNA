using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.VcfFile;

/// <summary>
/// An interface for a column value
/// </summary>
public interface IVcfColumnValue
{
    /// <summary>
    /// Name of the column
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Get the value of the field
    /// </summary>
    /// <typeparam name="T">The type of the field</typeparam>
    /// <returns>Returns the value of type {T}</returns>
    T GetValue<T>();
}

/// <summary>
/// A generic class for a column value that contains a value of type T 
/// </summary>
/// <param name="name"></param>
/// <param name="type"></param>
/// <param name="value"></param>
/// <typeparam name="T"></typeparam>
public class VcfColumnValue<T>(string name, string type, T value) : IVcfColumnValue
{
    /// <summary>
    /// Name of the column
    /// </summary>
    public string Name { get; } = name;
    /// <summary>
    /// Type of the column (integer, float, string etc)
    /// </summary>
    public string Type { get; } = type;
    /// <summary>
    /// The value of type T
    /// </summary>
    public T Value { get; } = value;

    /// <summary>
    /// Get value of type TI, which should be the same a T
    /// </summary>
    /// <typeparam name="TI">The type of the column</typeparam>
    /// <returns>The value as TI</returns>
    /// <exception cref="VcfColumnValueTypeException">Thrown if T and TI mismatches</exception>
    public TI GetValue<TI>()
    {
        if (Value is TI value) return value;
        throw new VcfColumnValueTypeException(typeof(TI),typeof(T), Name);
    }
}