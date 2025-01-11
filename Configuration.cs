using Microsoft.Extensions.Configuration;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
internal class Configuration : ConfigurationBase1
{
    public Configuration()
    {
    }

    private static object DebuggerDisplay => throw new NotImplementedException();

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}