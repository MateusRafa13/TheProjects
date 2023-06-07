using Dapper;
using ProjetoProva.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoProva.Mapeamento;
using System.ComponentModel;
using System.Drawing;

namespace ProjetoProva.Negocio
{
    public class PacienteDAO : Conexao
    {

        //adicionar novo Paciente

        public void Adicionar(int id_ala, string nome, string cpf, string rg, string celular)
        {

            banco.Execute("INSERT INTO Pacientes (id_alas, Nome, CPF, RG, Celular) VALUES(@id_ala, @Nome, @CPF, @RG, @Celular)",
                new { id_ala, nome, cpf, rg, celular });


        }

        //atualizar cadastro

        public void Atualizar(int id, int id_ala, string nome, string cpf, string rg, string celular)
        {
            banco.Execute("UPDATE Pacientes SET id_alas=@id_ala, Nome=@Nome, CPF=@CPF, RG=@RG, Celular=@Celular WHERE ID=@ID",
             new { id_ala, nome, cpf, rg, celular, id });
        }

        //Excluir Cadastro

        public void Excluir(int id)
        {
            banco.Execute("DELETE FROM pacientes WHERE id=@id",
                new { id });
        }

        // Buscar Paciente pelo ID

        public Paciente Buscar (int id)
        {
            return banco.Query<Paciente>("SELECT * FROM pacientes WHERE id=@id", 
                new { id }).SingleOrDefault();
        }

        //listar todos os pacientes

        public List<Paciente> ListarTodas()
        {

            return banco.Query<Paciente>("SELECT * FROM  Pacientes order by Nome").ToList();

        }

    }
}
