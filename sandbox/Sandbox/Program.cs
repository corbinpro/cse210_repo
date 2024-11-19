using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        
    }

    public abstract class Home
    {
        private new List <Room> _rooms;

        public void AddRooom(Room room)
        {
            _rooms.Add(room);
        }

    }

    public class Room //object for roooms list in house
    {
        private string _name;
        private List <string> devices;

        public void SetRoom(string name)
        {
            _name = name;
        }

        public void AddDevice(string device)
        {
            devices.Add(device);
        }

        public void TurnOffAllLights()
        {
        }

        public void TurnOffDevice()
        {
        }

        public void TurnOffAllDevices()
        {
        }

        public void ReportDeviceStatus()
        {
        }

        public void ReportOnlyOnDevices()
        {
        }

        public void ReportLongestOnDevices()
        {
        }
    }


    public abstract class SmartDevice
    {
        private string _name;
        private string _runningState;
        private string _runTime;

        public void SetSmartDevice(string name, string runningState, string runTime)
        {
            _name = name;
            _runningState = runningState;
            _runTime = runTime;
        }

        public string GetName()
        {
            return _name;
        }

        public abstract void PowerOn();


        public abstract void PowerOff();

        public string GetRunningState()
        {
            return _runningState;
        }

        public string GetRunTime()
        {
            return _runTime;
        }
    }

    public class SmartLight : SmartDevice
    {
        public override void PowerOn()
        {
            Console.WriteLine("SmartLight is on");
        }

        public override void PowerOff()
        {
            Console.WriteLine("SmartLight is off");
        }
    }

    public class SmartSpeaker : SmartDevice
    {
        public override void PowerOn()
        {
            Console.WriteLine("SmartSpeaker is on");
        }

        public override void PowerOff()
        {
            Console.WriteLine("SmartSpeaker is off");
        }
    }

    public class SmartTv : SmartDevice
    {
        public override void PowerOn()
        {
            Console.WriteLine("SmartTv is on");
        }

        public override void PowerOff()
        {
            Console.WriteLine("SmartTv is off");
        }

    }
    
}