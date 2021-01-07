using Slis.Data;
using Slis.Data.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.ConsoleUI
{
    public class PopolulationWriter     //서울시인구통계파일에서 인구 하나하나 읽어옴
    {
        #region singleton 
        private PopolulationWriter()
        {
            _libraries = Dao.Library.ToDictionary(); //생성자에서 필드가 돌아가도록 
        }

        private static PopolulationWriter _instance;

        public static PopolulationWriter Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PopolulationWriter();

                return _instance;
            }
        }
        #endregion

        private Dictionary<string, int> _libraries; //필드생성. 

        public void Write(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            //1구를 읽은 for문->각 구의 인구를 population으로 넘겨줌.
            for (int i = 4; i < lines.Length; i += 3) //윗줄 합계3줄 제외하고 4번째줄부터 읽음. 모든줄 끝날때까지. 한구는 합계,남,여 3줄이므로 3줄씩
            {
                for (int j = 1; j <= 2; j++)
                {
                    var list = ParseLine(lines[i + j]);

                    foreach (var population in list)
                        Dao.Population.Insert(population);
                }
            }

            //LookUp : 테이블을 조회하는 것
            //Console.WriteLine(AgeLookUp.Instance.GetName(4));  
            //Console.WriteLine(AgeLookUp.Instance[4]); //인덱서를 사용하여 case4(40대)를 조회
        }


        /// <summary>
        /// 엑셀값불러오기 위한 데이터 넣기.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private List<Population> ParseLine(string line)
        {
            //Dictionary<string, int> libraries = Dao.Library.ToDictionary
            //사전에 정의를 준다.
            //종로구 , 1                                                                            
            //이 코드를 사용할 경우 25개의 각 구역을 매번 해줘야하므로 필드를 만들어준다. 32nd줄

            string[] tokens = line.Split('\t');
            //종로구	남자	 71,623.50	4,253.00	6,051.50	11,707.50	10,104.00	10,973.50	12,279.50	16,254.50


            List<Population> populations = new List<Population>();  //인구 List

            //연령대별 인구 7칸 읽기 -> 인구 7개 생성 (ex. 중랑구 여자 20대 인구 => 인구1개)
            for (int i = 3; i < tokens.Length; i++)
            {
                Population population = new Population();
                population.LibraryId = _libraries[tokens[0]];
                population.IsMale = tokens[1] == "남자";      //IsMale은 bool형이므로 "남자"일 경우 ture, 여자일 경우 false로 받는다.
                population.AgeCode = i - 3;
                population.Value = Convert.ToInt32(tokens[i]);      //셀 한개에 담겨있는 인구값

                populations.Add(population);    //list에 읽은 인구 추가
            }

            return populations;
        }


    }
}
