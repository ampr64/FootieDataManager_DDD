namespace Domain.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsSameTypeAs(this object obj, object other) =>
            obj?.GetType().Equals(other?.GetType()) ?? other is null;
    }
}
