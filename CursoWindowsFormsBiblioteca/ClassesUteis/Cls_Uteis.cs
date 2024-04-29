using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.ClassesUteis
{
    public class Cls_Uteis
    {
        public static bool ValidaSenhaLogin(string senha)
        {
            if (senha == "curso") 
            { 
                return true;
            }

            return false;
        }
    }
}
