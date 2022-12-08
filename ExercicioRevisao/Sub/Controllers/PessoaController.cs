using Microsoft.AspNetCore.Mvc;

namespace Sub.Controllers;

[ApiController]
[Route("[controller]")]




public class PessoaController : ControllerBase
{
    [HttpPost]

    public static string reverse(string s)
    {
        char[] chararray = s.ToCharArray();
        Array.Reverse(chararray);
        return new string(chararray);
    }
    public Pessoa Post(Pessoa usuario)
    {
        //TAREFA 1: determinar o signo da pessoa com base no atributo "nascimento" e colocar ele no campo "signo"

        var n = usuario.nascimento;

        if (n != null)
        {
            if (n > new DateTime(n.Value.Year, 12, 21))
            {
                usuario.signo = "Capricornio";
            }
            else if (n > new DateTime(n.Value.Year, 11, 21))
            {
                usuario.signo = "Sagitario";
            }
            else if (n > new DateTime(n.Value.Year, 10, 22))
            {
                usuario.signo = "Escorpião";
            }
            else if (n > new DateTime(n.Value.Year, 9, 22))
            {
                usuario.signo = "Libra";
            }
            else if (n > new DateTime(n.Value.Year, 8, 22))
            {
                usuario.signo = "Virgem";
            }
            else if (n > new DateTime(n.Value.Year, 7, 22))
            {
                usuario.signo = "Leão";
            }
            else if (n > new DateTime(n.Value.Year, 6, 20))
            {
                usuario.signo = "Câncer";
            }
            else if (n > new DateTime(n.Value.Year, 5, 20))
            {
                usuario.signo = "Gemeos";
            }
            else if (n > new DateTime(n.Value.Year, 4, 20))
            {
                usuario.signo = "Touro";
            }
            else if (n > new DateTime(n.Value.Year, 3, 20))
            {
                usuario.signo = "Ares";
            }
            else if (n > new DateTime(n.Value.Year, 2, 19))
            {
                usuario.signo = "Peixes";
            }
            else if (n > new DateTime(n.Value.Year, 1, 21))
            {
                usuario.signo = "Aquario";
            }
            else
            {
                usuario.signo = "Capricornio";
            }

            //TAREFA 2: preencha o atributo "contrario" com o nome da pessoa escrito ao contrario, em letras maiusculas, e com cada letra separada por um espaco

            var c = reverse(usuario.nome);

            // if (usuario.contrario == null)
            // {
            //     c = "invalido";
            // }


            c += " " + usuario.nome.ToUpper();


            Console.WriteLine(usuario.contrario);

            usuario.contrario = c;


            return usuario;
        }

        return usuario;
    }
}
