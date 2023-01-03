﻿using Seafood.Domain.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seafood.Domain.Models.DataAccessModel
{

    public class VoucherSeafood : VBaseModel
    {
        public string Titel { get; set; }
        public string Code { get; set; }
        public int TypeVoucher { get; set; }
        public int ReductionAmount { get; set; }
        public int? ConditionsApply { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Note { get; set; }

    }
}
