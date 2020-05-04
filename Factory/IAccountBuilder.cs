namespace Factory
{
    public interface IAccountBuilder
    {
        public abstract Account Create(string name, int age);
    }
}
