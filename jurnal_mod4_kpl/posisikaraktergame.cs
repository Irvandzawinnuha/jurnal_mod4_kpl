using jurnal_mod4_kpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static jurnal_mod4_kpl.posisikaraktergame;

namespace jurnal_mod4_kpl
{
    public class posisikaraktergame
    {

        public enum state
        {
           Jongkok,
           Tengkurap, 
           Terbang,
        }
        public enum Trigger
        {
            TombolS,
            TombolW,
            TombolX,
        } 
    }
    public class pragram
    {
        enum State 
        {
            Jongkok,
            Tengkurap,
            Terbang,
            Berdiri
        }

        private static void Main(String[] arg)
        {
            var posisiAwal = posisikaraktergame.state.Jongkok;
            var posisiKedua = posisikaraktergame.state.Tengkurap;
            var posisIKetiga = posisikaraktergame.state.Terbang;

            State state = State.Jongkok;
            string[] screenName =
                { "Posisi landing",
                "Posisi  take off"
                };
            while (state != State.Terbang)
            {
                Console.WriteLine(screenName[(int)state] + " SCREEN");
                Console.Write("Enter Command : ");

                string command = Console.ReadLine();
                switch (state)
                {
                    case State.Jongkok:
                        if (command == "tombol s")
                            state = State.Tengkurap;
                        else if (command == "tombol w")
                            state = State.Berdiri;
                        else
                            state = State.START;
                        break;
                    case State.GAME:
                        if (command == "ESC")
                            state = State.PAUSE;
                        else
                            state = State.GAME;
                        break;
                    case State.PAUSE:
                        if (command == "BACK")
                            state = State.GAME;
                        else if (command == "HOME")
                            state = State.START;
                        else if (command == "QUIT")
                            state = State.EXIT;
                        else
                            state = State.PAUSE;
                        break;
                }
            }
            Console.WriteLine("EXIT SCREEN");
        }
        public void activeTrigger(Trigger trigger) 
        {
            

            
        }
    }

}
