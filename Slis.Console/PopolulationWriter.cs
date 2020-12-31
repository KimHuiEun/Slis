using Slis.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.ConsoleUI
{
    public class PopolulationWriter
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
            string[] lines = null;

            for (int i = 1; i < lines.Length; i += 2) //남자, 여자
            {
                List<Population> populations = Parse(lines[i], lines[i + 1]);

                foreach (var population in populations)
                {
                    Dao.Population.Insert(population);
                }
            }
            
        }

        /// <summary>
        /// 엑셀값불러오기 위한 데이터 넣기.
        /// </summary>
        /// <param name="line1"></param>
        /// <param name="line2"></param>
        /// <returns></returns>
        private List<Population> Parse(string line1, string line2) //lines1 = 남자, lines2 = 여자.
        {

            //Dictionary<string, int> libraries = Dao.Library.ToDictionary
            //사전에 정의를 준다.
            //종로구 , 1                                                                            
            //이 코드를 사용할 경우 25개의 각 구역을 매번 해줘야하므로 필드를 만들어준다. 32nd줄

            List<Population> populations = new List<Population>();

            string[] tokens = line1.Split('\t');
            //종로구	남자	 71,623.50	4,253.00	6,051.50	11,707.50	10,104.00	10,973.50	12,279.50	16,254.50

            for (int j = 1; j < 3; j++)
            {
                Population population = new Population();
                population.LibraryId = _libraries[tokens[0]]; // "종로구"
                
                if(tokens[1] == "남자") 
                {
                    population.IsMale = true;
                }
                //population.IsMale = tokens[1] == "남자";
                //if (j == 2) population.IsMale = tokens[1] == "여자";
                

                for (int i = 2; i < 9; i++)  //교수님코드 : int i = 2; i < 9; i++
                {
                    population.AgeCode = i + 1;
                    population.Value = Convert.ToInt32(Convert.ToDecimal(tokens[i])); 
                }

                //population.Value = _libraries[tokens[2]];
                
                populations.Add(population);
            }

            return populations;
        }
    }
}
