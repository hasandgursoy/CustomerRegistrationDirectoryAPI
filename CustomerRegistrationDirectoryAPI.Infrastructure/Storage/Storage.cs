using CustomerRegistrationDirectoryAPI.Infrastructure.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Infrastructure.Storage
{
    public class Storage
    {
        protected async Task<string> FileRenameAsync(string fileName)
        {
            string newFileName = await Task.Run<string>(() => {
                string extension = Path.GetExtension(fileName);
                string oldName = Path.GetFileNameWithoutExtension(fileName);
                string newFileName = $"{NameOperation.ChracterRegulatory(fileName)}-{DateTime.Now}{extension}";

                return newFileName;

            });

            return newFileName;
        }


    }
}
