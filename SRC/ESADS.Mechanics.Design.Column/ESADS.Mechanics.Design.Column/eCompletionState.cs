﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESADS.Mechanics.Design.Column
{
    public enum eCompletionState
    {
        OverReinforcedFailur,
        UnderReinforcedFailur,
        ReinforcementConjustionFailur,
        SuccessfullyCompleted,
        AboveMaxBarDiam,
        NotDesigned,
    }
}
