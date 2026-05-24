namespace TRnK.Flow
{
    public interface IState
    {
        void OnEnter();
        void OnTick(float deltaTime);
        void OnExit();
    }
}