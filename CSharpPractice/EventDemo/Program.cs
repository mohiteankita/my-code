using System;

namespace EventDemo
{
    class Publisher
    {
        public delegate void AlarmDelegate();
        public event AlarmDelegate RingAlarm;

        public void RaiseEvent()
        {
            while(true)
            {
                int h = DateTime.Now.Hour;
                int m = DateTime.Now.Minute;
                if (h == 14 && m == 8)
                {
                    //Raise event
                    RingAlarm();
                    break;
                }
            }
        }
    }

    class Subsciber
    {
        public void PrintMessage()
        {
            Console.WriteLine("Alarm is ringing!!!!");
        }
    }

    class Subscriber2
    {
        public void PrintMessage2()
        {
            Console.WriteLine("Alarm is ringing get ready for office!!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subsciber s = new Subsciber();
            Subscriber2 s2 = new Subscriber2();
            p.RingAlarm += new Publisher.AlarmDelegate(s.PrintMessage);
            p.RingAlarm += new Publisher.AlarmDelegate(s2.PrintMessage2);
            p.RaiseEvent();
        }
    }
}
