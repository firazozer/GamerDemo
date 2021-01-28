using System;
using System.Collections.Generic;
using System.Text;

namespace GamerDemo
{
    class CampaignManager : ICampaignService
    {


        public void NewCampaign()
        {
            // Yeni kampanya eklentileri buradan yapılacak.
            Console.WriteLine("Yeni Kampanya Sisteme Eklendi");
        }

        public void RemoveCampaign()
        {
            //Eski kampanyalar buradan silinecek
            Console.WriteLine("Kampanya Sistemden Kaldırıldı !");
        }

        void ICampaignService.UpdateCampaign()
        {
            //Kampanya güncellemesi buradan yapılacak
            Console.WriteLine("Mevcut Kampanya için Güncelleme Yapıldı");
        }
    }
}
