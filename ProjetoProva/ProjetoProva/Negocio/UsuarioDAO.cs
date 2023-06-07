using ProjetoProva.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ProjetoProva.Suporte;

namespace ProjetoProva.Negocios
{
    public class UsuarioDAO : Conexao
    {

        public Usuario Login(string email, string senha)
        {
            try
            {

                var usuario = banco.Query<Usuario>(
                    @"SELECT id, nome, email, ativo, AcessaUsuarios, AcessaInternados, AcessaMedicamentos

                    FROM Usuarios
                        WHERE email = @pemail and senha = @psenha",

                    new
                    {

                        @pemail = email,
                        @psenha = senha
                    }).SingleOrDefault();

                return usuario;

            }

            catch
            {
                return null;
            }
        }

     public bool CompararSenhas(int id, string senha)
        {
            try
            {
                var usuario = banco.Query<Usuario>(

                        @"SELECT id, nome, email, senha
                        FROM Usuarios
                        WHERE id = @pid",

                        new
                        {
                            @pid = id
                        }).SingleOrDefault();

                return usuario.senha == senha;
                        }
            catch { 
            return false; 
            }
                    
        }

        public bool AlteraPerfil(Usuario usuario) {

            return banco.Execute("update usuarios set " +
                "nome=@nome, " +
                "Email=@Email " +
                "where id=@id",
                usuario) == 1;

        }

        public bool AlterarSenha(Usuario usuario) {
            return banco.Execute("update usuarios set " +
                "senha=@senha " +
                "where id=@id",
                usuario) == 1;

        }

   


        //Adicionar Usuário
        public void Adicionar(string nome, string email, string senha, bool acessaUsuarios, bool acessaInternados, bool acessaMedicamentos, bool ativo)
        {
            banco.Execute("INSERT INTO Usuarios (Nome, email, senha, AcessaUsuarios, AcessaInternados, AcessaMedicamentos, ativo) VALUES(@Nome, @email, " +
                "@senha, @AcessaUsuarios, @AcessaInternados, @AcessaMedicamentos, @ativo)",
                new { nome, email, senha, acessaUsuarios, acessaInternados, acessaMedicamentos, ativo });
        }

        //Atualizar Usuario

        public void Atualizar(int id, string nome, string email, string senha, bool acessaUsuarios, bool acessaInternados, bool acessaMedicamentos, bool ativo)
        {
            banco.Execute("UPDATE Usuarios SET Nome=@Nome, email=@email, senha=@senha, AcessaUsuarios=@AcessaUsuarios, AcessaInternados=@AcessaInternados," +
                " AcessaMedicamentos=@AcessaMedicamentos, ativo=@ativo WHERE ID=@ID",
                new { nome, email, senha, acessaUsuarios, acessaInternados, acessaMedicamentos, ativo, id });
        }

        //Excluir Usuario

        public void Excluir(int id)
        {
            banco.Execute("DELETE FROM Usuarios WHERE ID=@ID",
                new { id });
        }

        //Buscar Usuario por ID

        public Usuario Buscar(int id)
        {
            return banco.Query<Usuario>("SELECT * FROM Usuarios WHERE ID=@ID",
                new { id }).SingleOrDefault();
        }

        //Listar Todos Usuarios

        public List<Usuario> ListarTodas()
        {
            return banco.Query<Usuario>("SELECT * FROM Usuarios order by Nome").ToList();
        }
    }
}
