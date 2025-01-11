
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal record InventoryContext(object Products)
{
    public object Products { get; internal set; } = Products;

    internal async Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    internal void Update(object product)
    {
        throw new NotImplementedException();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}