using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ProjetoProva.Mapeamento;
using ProjetoProva.Suporte;

namespace ProjetoProva.Negocio
{
    public class MedicamentoDAO: Conexao
    {
        // Adicionar Novo Medicamento

        public void Adicionar(string nome, int quantidade)
        {
            banco.Execute("INSERT INTO Medicamentos (Nome, Quantidade) VALUES(@Nome, @Quantidade)",
                new { nome, quantidade });
        }

        // Atualizar Medicamento
        public void Atualizar(int id, string nome, int quantidade)
        {
            banco.Execute("UPDATE Medicamentos SET Nome=@Nome, Quantidade=@Quantidade WHERE ID=@ID",
                new { nome, quantidade, id });
        }

        //Excluir Medicamento

        public void Excluir(int id)
        {
            banco.Execute("DELETE FROM Medicamentos WHERE ID=@ID",
                new { id });
        }

        // Buscar por id
        public Medicamento Buscar(int id)
        {
            return banco.Query<Medicamento>("SELECT * FROM Medicamentos WHERE ID=@ID",
                new { id }).SingleOrDefault();
        }

        //Listar todos Medicamentos
        public List<Medicamento> ListarTodas()
        {
            return banco.Query<Medicamento>("SELECT * FROM Medicamentos order by Nome").ToList();
        }
    }
}
