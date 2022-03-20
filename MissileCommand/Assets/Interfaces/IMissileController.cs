public interface IMissileController
{
    float distance { get; }
    float timer { get; }

    void calcDistance();
    void Move();
}