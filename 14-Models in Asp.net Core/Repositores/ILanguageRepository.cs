using _14_Models_in_Asp.net_Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _14_Models_in_Asp.net_Core.Repositores
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}