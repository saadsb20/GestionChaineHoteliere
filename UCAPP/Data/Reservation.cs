using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCAPP.Data
{
    public class Reservation
    {
        public List<Chambre> Chambres { get; set; }
        public Reservation()
        {
            Chambres = new List<Chambre>
            {
                new Chambre() { Num = 1, Status = false },
                new Chambre() { Num = 2, Status = true  },
                new Chambre() { Num = 3, Status = false },
                new Chambre() { Num = 4, Status = false },
                new Chambre() { Num = 5, Status = true  },
                new Chambre() { Num = 6, Status = false },
                new Chambre() { Num = 7, Status = false },
                new Chambre() { Num = 8, Status = true  },
                new Chambre() { Num = 9, Status = false }
            };

        }

        public Color GetStatus(int num)
        {
            Chambre chambre = Chambres.FirstOrDefault(x => x.Num == num);
            return chambre == null ? Color.Gray : 
                chambre.Status ? Color.Yellow : Color.Red; 
        }

    }
}
