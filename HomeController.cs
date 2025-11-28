using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;
using System.Diagnostics;
using Trabalho2.Models;

namespace Trabalho2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Exercicio1()
        {
            return View();
        }

        public IActionResult Exercicio2()
        {
            return View();
        }
        public IActionResult Exercicio3()
        {
            return View();
        }
        public IActionResult Exercicio4()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroUsuario()
        {
            return View();
        }

        public IActionResult ConsultarAluno()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BuscarAluno(String nome)
        {
            String select = "";
            if (nome == null || nome.Equals(""))
            {
                select = "select * from aluno";
            }
            else
            {
                select = "select * from aluno where nome like '%" + nome + "%'";
            }
            String stringConnection = "Data Source=banco_de_dados.db; Version = 3; New = True; Compress = True; ";
            SQLiteConnection sqlite_conn = new SQLiteConnection(stringConnection);
            sqlite_conn.Open();
            SQLiteCommand comandoSQL = new SQLiteCommand(select, sqlite_conn);
            SQLiteDataReader dr = comandoSQL.ExecuteReader();
            List<Aluno> listaAluno = new List<Aluno>();
            while (dr.Read())
            {
                Aluno al = new Aluno();
                al.nome = dr["nome"].ToString()!;
                al.email = dr["email"].ToString()!;
                al.curso = dr["curso"].ToString()!;
                listaAluno.Add(al);
            }
            return Json(listaAluno);
        }

        [HttpPost]
        public IActionResult inserirAluno([FromBody] Aluno aluno)
        {
            String cmdinsert = "insert into aluno(nome,curso,email,senha) ";
            cmdinsert += $"values ('{aluno.nome}','{aluno.curso}','{aluno.email}','{aluno.senha}')";

            String stringConnection = "Data Source=banco_de_dados.db; Version = 3; New = True; Compress = True; ";
            SQLiteConnection sqlite_conn = new SQLiteConnection(stringConnection);
            sqlite_conn.Open();

            SQLiteCommand comandoSQL = new SQLiteCommand(cmdinsert, sqlite_conn);
            int qtd_linhas_inseridas = comandoSQL.ExecuteNonQuery();

            string resposta = "";
            if (qtd_linhas_inseridas > 0)
                resposta = "Usuario cadastrado com sucesso!!!";
            else
                resposta = "Não foi possível cadastrar o Usuario!!!";

            sqlite_conn.Close();

            return Json(resposta);
        }

        [HttpDelete]
        public IActionResult ExcluirUsuario(string email)
        {
            try
            {
                String cmdDelete = $"DELETE FROM aluno WHERE email = '{email}'";

                String stringConnection = "Data Source=banco_de_dados.db; Version = 3; New = True; Compress = True; ";
                using (SQLiteConnection sqlite_conn = new SQLiteConnection(stringConnection))
                {
                    sqlite_conn.Open();
                    SQLiteCommand comandoSQL = new SQLiteCommand(cmdDelete, sqlite_conn);
                    int qtd_linhas_afetadas = comandoSQL.ExecuteNonQuery();

                    string resposta = "";
                    if (qtd_linhas_afetadas > 0)
                        resposta = "Usuário excluído com sucesso!";
                    else
                        resposta = "Usuário não encontrado ou já foi excluído.";

                    return Json(resposta);
                }
            }
            catch (Exception ex)
            {
                return Json($"Erro ao excluir usuário: {ex.Message}");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Aluno
    {
        public String nome { get; set; }
        public String curso { get; set; }
        public String email { get; set; }
        public String senha { get; set; }
    }
}