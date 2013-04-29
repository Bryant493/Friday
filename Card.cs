using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// This is a test change. -- Nate Howe

namespace Friday
{
    /**
     * An interface representing a Card Object.  This is created basically so that Hazzard Cards and Robinson cards can be added to the same list.
     */
    interface Card
    {
        String getName();
        int getFight();
        String toString();
    }
}
