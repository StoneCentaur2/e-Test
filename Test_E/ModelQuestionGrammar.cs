using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_E
{
    public class ModelQuestionGrammar
    {
        public string Question { get; set; }
        public string optionA { get; set; }
        public string optionB { get; set; }
        public string optionC { get; set; }
        public string optionD { get; set; }
        public int difficulty { get; set; }
        public string optionCorrect { get; set; }
        public double points { get; set; }
        public string section { get; set; }
        public string tipoTest { get; set; }
        public DateTime dateTime { get; set; }
    }
}
