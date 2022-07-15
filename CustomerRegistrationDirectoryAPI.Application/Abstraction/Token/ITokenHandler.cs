using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Abstraction.Token
{
    public class ITokenHandler 
    {
        DTOs.Token CreateAccessToken(int minute);

    }
}
