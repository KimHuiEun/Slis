using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data.Types
{
    public class AgeLookUp
    {
        /// <summary>
        /// 싱글톤 적용
        /// </summary>
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
                case 1:
                    return "10대";
                case 2:
                    return "20대";
                case 3:
                    return "30대";
                case 4:
                    return "40대";
                case 5:
                    return "50대";
                case 6:
                    return "60대 이상";
                default:
                    throw new Exception($"{ageCode}는 유효하지 않은 값이에요");
            }
        }

        /// <summary>
        /// 인덱서를 사용하여 열거형 ageCode를 GetName에 적용.
        /// </summary>
        /// <param name="ageCode"></param>
        /// <returns></returns>
        public string this[int ageCode]
        {
            get
            {
                return GetName(ageCode);
            }
        }

    }
}
