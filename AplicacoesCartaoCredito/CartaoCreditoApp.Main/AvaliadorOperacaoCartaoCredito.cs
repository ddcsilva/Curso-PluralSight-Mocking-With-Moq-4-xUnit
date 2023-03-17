namespace CartaoCreditoApp.Main
{
    public class AvaliadorOperacaoCartaoCredito
    {
        private const int IdadeMaximaReferenciaAutomatica = 20;
        private const int LimiteRendaAlta = 100_000;
        private const int LimiteRendaBaixa = 20_000;

        public StatusOperacaoCartaoCredito Evaluate(OperacaoCartaoCredito application)
        {
            if (application.RendaBrutaAnual >= LimiteRendaAlta)
            {
                return StatusOperacaoCartaoCredito.AceitoAutomaticamente;
            }

            if (application.Idade <= IdadeMaximaReferenciaAutomatica)
            {
                return StatusOperacaoCartaoCredito.EncaminhadoParaPessoa;
            }

            if (application.RendaBrutaAnual < LimiteRendaBaixa)
            {
                return StatusOperacaoCartaoCredito.RecusadoAutomaticamente;
            }

            return StatusOperacaoCartaoCredito.EncaminhadoParaPessoa;
        }
    }
}
