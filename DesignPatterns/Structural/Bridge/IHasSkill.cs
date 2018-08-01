namespace DesignPatterns.Structural.Bridge
{
    public interface IHasSkill
    {
        void Attach(Skill skill);
        void Detach();
        void Perform();
    }
}