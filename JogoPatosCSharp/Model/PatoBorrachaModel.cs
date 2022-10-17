namespace JogoPatosCSharp.Model
{
    public class PatoBorrachaModel : PatoModel, GrasnarModel
    {
        public PatoBorrachaModel()
        {
            SetComportamento(new NaoVoarModel());
        }

        public override string Mostrar()
        {
            return "Pato de borracha aparece.";
        }

        public string Grasnar()
        {
            return "quá quá. Grr";
        }
    }
}
