using System;
using System.IO;
using System.Threading.Tasks;

namespace _14_Models_in_Asp.net_Core.Models
{
    public class HttpPostedFileBase
    {
        public string FileName { get; internal set; }

        internal Task CopyToAsync(FileStream fileStream)
        {
            throw new NotImplementedException();
        }
    }
}