using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public interface IUser
    {
        int FirstName { get; set; }
        int lastName { get; set; }
        int emailAddress { get; set; }
        int registrationNumber { get; set; }
    }
}
