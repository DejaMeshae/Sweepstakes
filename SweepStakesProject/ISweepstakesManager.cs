﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public interface ISweepstakesManager
    {
        //*****Hold Methods*********
        void InsertSweepstakes(SweepstakesClass sweepstakes);

        SweepstakesClass GetSweepstakes();
    }
}
