﻿using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahappss.Models
{
    public class Budget
    {
      public int Id { get; set; }

      public DateTime StartDate { get; set; }

      public DateTime EndDate { get; set; }
        
      public double BudgetAmount { get; set; }

    }
}
