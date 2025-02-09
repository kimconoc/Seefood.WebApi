﻿using Seafood.Domain.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seafood.Domain.Models.DataAccessModel
{
    [Table("ProdInfos")]
    public class ProdInfo : VBaseModel
    {
        public Guid? ProductId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
