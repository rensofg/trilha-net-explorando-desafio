namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A capacidade da acomodação não pode ser inferior ao número de hóspedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                decimal desconto = (valor * 10) / 100;
                valor = valor - desconto;
            } 

            return valor;
        }
    }
}