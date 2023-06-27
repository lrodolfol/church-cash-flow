using System.Text.Json;

namespace Registration.DomainBase.Entities.ChurchSystem;

public class JsonStringResult<T>
{
    public T Model { get; set; }

    public JsonStringResult(T model)
    {
        Model = model;
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(Model);
    }
}