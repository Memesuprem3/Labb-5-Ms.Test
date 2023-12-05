﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Projekt_i_grupp___Code_Crusades__SUT23_
{
    public class TransferLog
    {
        public Transfer TransferDetails {  get; set; }
        public DateTime TransferTime { get; set; }

        public TransferLog(Transfer transferDetails)
        {
            TransferDetails = transferDetails;
            TransferTime = DateTime.Now;
        }
    }


}
