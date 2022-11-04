using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_carpinteria_1._1.Models
{
    public class SecureEstorageService : ISecureStorageService
    {
        public async Task Guardar(string key, string token)
        {
            await SecureStorage.Default.SetAsync(key, token);
        }

        public async Task<string> Recuperar(string key)
        {
            return await SecureStorage.Default.GetAsync(key);
        }
        public void BorrarClaveMetodo(string key)
        {
            bool d = SecureStorage.Default.Remove(key);
        }

        Task ISecureStorageService.BorrarClave(string key)
        {
            throw new NotImplementedException();
        }
    }
}
