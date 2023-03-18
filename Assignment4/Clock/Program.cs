using System;

public delegate void TickHandler(object sender, DateTime time);
public delegate void AlarmHandler(object sender, DateTime time);

//publisher
class ClockRun
{
    public event TickHandler OnTick;
    public event AlarmHandler OnAlarm;
    public string alarmTime;// 闹钟时间

    public void runtime()//时间进行
    {
        while (true)
        {
            DateTime now = DateTime.Now;
            OnTick(this, now);
            if (now.ToString() == alarmTime)
            {
                OnAlarm(this, now);
            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}

//Subscriber
class Clock
{
    public ClockRun clk = new ClockRun();
    public Clock(string alarm)
    {
        clk.alarmTime = alarm;
        clk.OnTick += onTick;
        clk.OnAlarm += onAlarm;
    }
    void onTick(object sender, DateTime time)
    {
        Console.WriteLine($"嘀嗒嘀嗒，现在是{time}。");
    }
    void onAlarm(object sender, DateTime time)
    {
        Console.WriteLine($"叮铃铃，{time}了，要迟到啦。");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Clock ck = new Clock("2023/3/18 17:15:40");
        ck.clk.runtime();
    }
}