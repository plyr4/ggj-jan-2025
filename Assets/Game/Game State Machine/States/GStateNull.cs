public class GStateNull : GStateBase
{
    public GStateNull()
    {
    }
    
    public GStateNull(StateMachineMono context, StateFactory factory) : base(context, factory)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();

        if (_context == null) return;
    }

    public override void OnExit()
    {
        base.OnExit();

        if (_context == null) return;
    }
}