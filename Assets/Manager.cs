using QFramework;

public class Manager : Architecture<Manager>
{
    protected override void Init()
    {
        this.RegisterModel(new Model());
    }
}
