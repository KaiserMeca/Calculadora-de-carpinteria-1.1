using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_carpinteria_1._1.Models
{
    public interface ISecureStorageService
    {
        Task Guardar(string key, string token);
        Task<string> Recuperar(string key);
        Task BorrarClave(string key);
    }
}
