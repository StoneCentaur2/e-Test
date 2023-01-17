using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_E
{
    internal class ModelQuestionAudio
    {
        public Stream audio { get; set; }
        public string name { get; set; }
        public string Question { get; set; }
        public string optionA { get; set; }
        public string optionB { get; set; }
        public string optionC { get; set; }
        public string optionD { get; set; }
        public string optionCorrect { get; set; }
        public double points { get; set; }
    }
}
