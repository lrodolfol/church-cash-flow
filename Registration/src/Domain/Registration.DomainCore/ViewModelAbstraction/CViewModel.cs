namespace Registration.DomainCore.ViewModelAbstraction;
public abstract class CViewModel
{
    public object? Data { get; set; }
    public List<string> Errors { get; set; } = new();

    public void SetDataErros(object data, List<string> errors)
    {
        Data = data;
        Errors = errors;
    }

    public void SetEmpty()
    {
        Data = null;
        Errors = null;
    }

    public void SetData(object? data)
    {
        Data = data;
    }

    public void SetErrors(List<string> errors)
    {
        Errors!.AddRange(errors);
    }

    public void SetErrors(string error)
    {
        Errors!.Add(error);
    }
}