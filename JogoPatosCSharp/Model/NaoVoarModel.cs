namespace JogoPatosCSharp.Model
{
    public class NaoVoarModel : VoarModel
    {

        public NaoVoarModel()
        {
            
        }

        public double GetVelocidade()
        {
            return 0;
        }

        public string Voar()
        {
            return $"Esse pato não voa. Velocidade: {GetVelocidade()}";
        }
    }
}
