using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogin.Views
{

    public class PortalDashBoardMenuItem
    {
        public PortalDashBoardMenuItem()
        {
            TargetType = typeof(PortalDashBoardDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}