namespace Enhetskonvertering
{
    public interface IInputHandler
    {
        public bool ReadInput(out int result);

        public bool ReadInput(string typ, string unit, out double result);

        public bool ReadInput(Meny.TempMenyChoices tempTyp, out double result);
    }
}