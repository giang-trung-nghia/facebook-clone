﻿using Facebook.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Application.Dtos.Conservation
{
    public class ConservationDto : BaseDto
    {
        public DateTime LastMessageTime { get; set; }
        public string Name { get; set; }
    }
}
