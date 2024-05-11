﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class RoomType
    {
        public RoomType()
        {
            RoomInformations = new HashSet<RoomInformation>();
        }

        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string TypeDescription { get; set; }
        public string TypeNote { get; set; }

        public virtual ICollection<RoomInformation> RoomInformations { get; set; }
    }
}
