using System.Diagnostics;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
internal class ConfigurationBase1
{
    private static object DebuggerDisplay
    {
        get
        {
            throw new NotImplementedException();
        }
    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}