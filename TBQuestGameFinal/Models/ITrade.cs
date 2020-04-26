using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    interface ITrade
    {
        List<string> Barter { get; set; }

        string Trade();

    }
}
