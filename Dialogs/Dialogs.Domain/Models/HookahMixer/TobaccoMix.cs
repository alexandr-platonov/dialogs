namespace Dialogs.Domain.Models.HookahMixer
{
    public class TobaccoMix
    {
        public TobaccoMix(Tobacco tobacco, int percent)
        {
            Tobacco = tobacco;
            Percent = percent;
        }

        public Tobacco Tobacco { get; }
        public int Percent { get; }
    }
}