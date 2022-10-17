namespace JogoPatosCSharp.Model
{
    public class PatoRuivoModel : PatoModel, GrasnarModel
    {
        public PatoRuivoModel()
        {
            SetComportamento(new VoarAsaModel());
        }

        public override string Mostrar()
        {
            return "Pato ruivo aparece.";
        }

        public string Grasnar()
        {
            return "quá quá.";
        }
    }
}
