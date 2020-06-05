namespace Aula11_atividade
{
    public class Calculo
    {
        
        public string Calcular(){
            return "Não houve nenhum calculo a ser aplicado";
        }

        public string Calcular(int dano){
            return "O dano do jogador é"+dano;
        }

        public string Calcular(int dano, int arma){
            return "O dano do jogador com arma é"+ (dano+arma);
        }

        public string Calcular(string arma, string principal){
            return $"A arma do personagem é {arma} {principal}";
        }

    }
}