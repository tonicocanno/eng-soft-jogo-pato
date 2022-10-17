namespace JogoPatosCSharp.Model
{
    public class VoarAsaModel : VoarModel
    {
        private readonly double velocidade;

        public VoarAsaModel()
        {
            this.velocidade = 10;
        }

        public double GetVelocidade()
        {
            return velocidade;
        }

        public string Voar()
        {
            return $"Voando como um pássaro. Velocidade: {velocidade}";
        }
    }
}
