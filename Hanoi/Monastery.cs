﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Hanoi
{
    public sealed class Monastery
    {
        private readonly List<DiscMove> _moves = new List<DiscMove>();
        private static readonly List<PegLocation> _locations = new List<PegLocation>();
        static Monastery()
        {
            _locations.AddRange((PegLocation[])Enum.GetValues(typeof(PegLocation)));
        }
        public IEnumerable<DiscMove> Moves => _moves;
        public void MoveDisks(short count, PegLocation origin, PegLocation destination)
        {
            if (count < 1) return;
            var intermediate = _locations.Where(_ => _ != origin && _ != destination).Single();
            MoveDisks((short)(count - 1), origin, intermediate);
            _moves.Add(new DiscMove
            {
                Id = count,
                Origin = origin,
                Destination = destination
            });
            MoveDisks((short)(count - 1), intermediate, destination);
        }
    }
}
