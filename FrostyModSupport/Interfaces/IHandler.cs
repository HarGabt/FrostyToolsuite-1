using Frosty.Sdk.Utils;

namespace Frosty.ModSupport.Interfaces;

public interface IHandler
{
    /// <summary>
    /// Loads the data of a resource and merges it and dispose of it after it's done with it.
    /// </summary>
    /// <param name="inData">The data from of the resource from the mod, it is disposed after this function is called.</param>
    public void Load(Block<byte> inData);

    /// <summary>
    /// Creates the final resource.
    /// </summary>
    /// <param name="modEntry">The mod entry to modify.</param>
    /// <param name="data">The final data of the resource.</param>
    public void Modify(IModEntry modEntry, out Block<byte> data);
}