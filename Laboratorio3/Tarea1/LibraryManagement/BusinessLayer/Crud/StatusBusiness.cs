﻿using CommonLayer.Entities;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Crud
{
    public class StatusBusiness
    {
        StatusData statusData = new StatusData();

        public DataTable GetStatuses()
        {
            return statusData.GetAllStatuses();
        }
    }
}
