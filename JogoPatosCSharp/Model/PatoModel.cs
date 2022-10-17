namespace JogoPatosCSharp.Model
{
    public abstract class PatoModel
    {
        protected VoarModel VoarModel;

        abstract public string Mostrar();

        public string Nadar()
        {
            return "Pato nada.";
        }

        public void SetComportamento(VoarModel padrao)
        {
            VoarModel = padrao;
        }

        public string Comportamento()
        {
            return VoarModel.Voar();
        }
    }
}