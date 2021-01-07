using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data.Types
{
    public class AgeLookUp
    {
        private AgeLookUp()
        {
        }

        private static AgeLookUp _instance;

        public static AgeLookUp Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AgeLookUp();

                return _instance;
            }
        }

        public string GetName(int ageCode)
        {
            switch(ageCode)
            {
                case 0:
                    return "10대 미만";
                case 6:
                    return "60대 이상";
                default:
                    throw new Exception($"{ageCode}는 유효하지 않은 값이에요");
            }
        }

        public string this[int ageCode]
        {
            get
            {
                return GetName(ageCode);
            }
        }

    }
}
