﻿using System;
using System.Collections.Generic;

namespace NexusForever.Shared.Database.Character.Model
{
    public partial class CharacterAppearance
    {
        public ulong Id { get; set; }
        public byte Slot { get; set; }
        public ushort DisplayId { get; set; }

        public Character IdNavigation { get; set; }
    }
}
