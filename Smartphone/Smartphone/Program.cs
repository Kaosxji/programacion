using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public class Smartphone
    {
        static void Main(string[] args)
        {
            Smartphone HuaweiY9s = new Smartphone();
            HuaweiY9s.NetTech = "GMS/HSPA/LTE";
            HuaweiY9s.Launch = new Launch();
            HuaweiY9s.Launch.Announced = "2019,Noviembre del 08";
            HuaweiY9s.Launch.Status = "Disponible";
            HuaweiY9s.Body.DimensionsLargo = 163.1f;
            HuaweiY9s.Body.DimensionsAncho = 77.2f;
            HuaweiY9s.Body.Weight = 206;
            HuaweiY9s.Body.Build = "Glass front,Glass back,Aluminum frame";
            HuaweiY9s.Body.SIM = "Hybrid Dual SIM, Nano SIM";
            HuaweiY9s.Display = new Display();
            HuaweiY9s.Display.Type = "IPS LCD";
            HuaweiY9s.Display.Size = 6.59f;
            HuaweiY9s.Display.ResolutionLargo = 1080;
            HuaweiY9s.Display.ResolutionAncho = 2340;
            HuaweiY9s.Plataform.OS = "Android 9.0,EMUI 9.1";
            HuaweiY9s.Plataform.Chipset = "Kirin 710F";
            HuaweiY9s.Plataform.CPU = "Octa-Core";
            HuaweiY9s.Plataform.GPU = "Mail-G51 MP4";
            HuaweiY9s.Memory.CardSlot = "GPS,GLONASS,BDS";
            HuaweiY9s.Memory.Internal = 128;
            HuaweiY9s.MainCamara = new MainCamara();
            HuaweiY9s.MainCamara.Triple = 48;
            HuaweiY9s.MainCamara.Features = "LED flash,HDR,panorama";
            HuaweiY9s.MainCamara.Video = 1080;
            HuaweiY9s.SelfieCam.Single = "Motorized pop-up 16 MP";
            HuaweiY9s.SelfieCam.Features = "HDR";
            HuaweiY9s.SelfieCam.Video = 1080;
            HuaweiY9s.Sound = new Sound();
            HuaweiY9s.Sound.LoudSpeaker = true;
            HuaweiY9s.Sound.TresPuntoCincoJack = true;
            HuaweiY9s.Comms = new COMMS();
            HuaweiY9s.Comms.WLAN = "Wi-FI 802.11";
            HuaweiY9s.Comms.Bluetooth = 4.2f;
            HuaweiY9s.Comms.Positioning = "GPS,GLONASS,BDS";
            HuaweiY9s.Comms.NFC = false;
            HuaweiY9s.Comms.Radio = "FM radio";
            HuaweiY9s.Comms.USB = "USB tipo C";
            HuaweiY9s.Features = new Features();
            HuaweiY9s.Features.Sensors = "Fingerprint";
            HuaweiY9s.Battery = new Battery();
            HuaweiY9s.Battery.Type = "Li-Po 4000mAh";
            HuaweiY9s.Battery.Charging = 10;
            HuaweiY9s.Misc = new Misc();
            HuaweiY9s.Misc.Colors = "Midnight Black,Breathing Crystal,Phantom Purple";
            HuaweiY9s.Misc.Models = "STK-L21,STK-LX3,STK-L22";
            HuaweiY9s.Misc.Price = "About 220 EUR";



        }
    }
}
