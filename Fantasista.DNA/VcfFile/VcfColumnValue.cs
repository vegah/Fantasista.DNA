using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.VcfFile;

public interface IVcfColumnValue
{
    string Name { get; }
    T GetValue<T>();
}

public class VcfColumnValue<T>(string name, string type, T value) : IVcfColumnValue
{
    public string Name { get; } = name;
    public string Type { get; } = type;
    public T Value { get; } = value;

    public TI GetValue<TI>()
    {
        if (Value is TI value) return value;
        throw new VcfColumnValueTypeException(typeof(TI),typeof(T), Name);
    }
}