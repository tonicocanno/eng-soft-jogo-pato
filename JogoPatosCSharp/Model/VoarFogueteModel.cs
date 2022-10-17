namespace JogoPatosCSharp.Model
{
    public class VoarFogueteModel : VoarModel
    {
        private readonly double velocidade;

        public VoarFogueteModel()
        {
            this.velocidade = 1000;
        }

        public double GetVelocidade()
        {
            return velocidade;
        }

        public string Voar()
        {
            return $"Voando como um foguete. Velocidade: {velocidade}";
        }
    }
}
