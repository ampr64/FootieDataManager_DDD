namespace Domain.Common
{
    public interface IBusinessRule
    {
        void Enforce();
    }

    interface IBusinessRule<out T>
    {
        T Enforce();
    }
}
