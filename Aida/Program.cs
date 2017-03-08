using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Seech.Recognition;
using System.Speech.Synthesis;

namespace Aida
{
    class Program
    {

        private static SpeechRecognitionEngine engine = null; //Objetos
        private static SpeechSynthesizer sp = null; //Objeto

        static void Main(string[] args)

        {

            //Quem ler esse comentario e quiser que eu comente sobre AIDA.
            //Comenta abaixo o video....

            engine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("pt-BR");
            engine.SetInputToDefaulAudioDevice();
            sp = new SpeechSynthesizer();


            String[] conversas = { "ola", "boa noite", "boa tarde ", "tudo bem" };

            Choices c_conversas = new Choices(conversas);

            GrammarBuilder gb_conversas = new GrammarBuilder();





        }
    }
}
