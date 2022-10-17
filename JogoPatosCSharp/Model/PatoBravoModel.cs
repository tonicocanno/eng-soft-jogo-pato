namespace JogoPatosCSharp.Model
{
    public class PatoBravoModel : PatoModel, GrasnarModel
    {
        public PatoBravoModel()
        {
            SetComportamento(new VoarAsaModel());
        }

        public override string Mostrar()
        {
            return "Pato bravo aparece.";
        }

        public string Grasnar()
        {
            return "quá quá. Grr";
        }
    }
}
