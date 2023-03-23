
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(int _idPermisao, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Insert into PermissaoGrupoUsuario(Cod_Descricao, Cod_Usuario)
                                  Values(@Cod_Descricao, @Cod_Usuario)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Cod_Descricao", _idPermisao);
                cmd.Parameters.AddWithValue("@Cod_Usuario", _idGrupoUsuario);

                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma permissão no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"update Permissao set Descricao = @Descricao where IdDescricao = @IdDescricao ";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);
                cmd.Parameters.AddWithValue("@IdDescricao", _permissao.IdDescricao);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a permissao no banco de dados: " + ex.Message);
            }
        }


        public void Excluir(int _IdDescricao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"delete from Permissao where IdDescricao = @IdDescricao";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", _IdDescricao);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a permissao no banco de dados: " + ex.Message);
            }
        }


        public List<Permissao> BuscarPorIDDescricao(int _IdDescricao)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao.IdDescricao, Permissao.Descricao from Permissao inner join PermissaoGrupoUsuario on Permissao.IdDescricao = PermissaoGrupoUsuario.Cod_GrupoUsuario where IdDescricao = @Cod_Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Cod_Descricao", _IdDescricao);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.IdDescricao = Convert.ToInt32(rd["IdDescricao"]);
                        permissao.Descricao = rd["Descricao"].ToString();

                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as permissões: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public bool ExisteRelacionamento(int idPermissao, int id)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"Select 1 as Retorno From PermissaoGrupoUsuario where IdDescricao = @IdDescricao and IdGrupoUsuario = IdGrupoUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDescricao", idPermissao);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as permissões: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }

}

