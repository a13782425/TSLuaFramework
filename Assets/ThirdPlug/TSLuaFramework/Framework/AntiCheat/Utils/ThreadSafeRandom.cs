﻿#if ANTI_CHEAT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLuaFramework
{
    internal class ThreadSafeRandom
    {
        private static readonly Random Global = new Random();

        [ThreadStatic]
        private static Random local;

        public static int Next(int minInclusive, int maxExclusive)
        {
            var inst = local;
            if (inst != null) return inst.Next(minInclusive, maxExclusive);

            int seed;

            lock (Global)
                seed = Global.Next();

            local = inst = new Random(seed);
            return inst.Next(minInclusive, maxExclusive);
        }

        public static int Next()
        {
            return Next(1, int.MaxValue);
        }

        public static int Next(int maxExclusive)
        {
            return Next(1, maxExclusive);
        }
    }
}

#endif