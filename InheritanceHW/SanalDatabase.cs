using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    public static class SanalDatabase
    {
        private static ArrayList db = new ArrayList();

        public static void UrunEkle(BaseClass data)
        {
            if (data!=null && !string.IsNullOrEmpty(data.Barkod))
            {
                db.Add(data);
            }
        }

        public static bool  BarkodKontrol(string barkod)
        {

            bool kontrolIslemi = false;
            for (int i = 0; i < db.Count; i++)
            {
                BaseClass temp = (BaseClass)db[i];

                if (temp.Barkod==barkod)
                {
                    kontrolIslemi = true;
                }

            }
            return kontrolIslemi;
        }

    }
}
