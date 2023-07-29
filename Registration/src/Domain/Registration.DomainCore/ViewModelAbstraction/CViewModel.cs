namespace Registration.DomainCore.ViewModelAbstraction;
public abstract class CViewModel
{
    public object? Data { get; set; }
    public List<string?>? Errors { get; set; } = new();

    public void SetDataErros(object data, List<string> errors)
    {
        Data = data;
        Errors = new List<string?>(errors);
    }

    public void SetEmpty()
    {
        Data = null;
        Errors = null;
    }

    public void SetData(object data)
    {
        Data = data;
    }

    public void SetErrors(List<string> errors)
    {
        Errors = new List<string?>(errors);
    }

    public void SetErrors(string error)
    {
        Errors!.Add(error);
    }
}