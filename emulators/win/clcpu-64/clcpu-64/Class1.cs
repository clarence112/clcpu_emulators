using System;
using System.Collections.Generic;
using System.Text;

namespace clcpu_64 {
    public static class virtualSystem {

        public static byte[] systemRam;
        public static cpuCore[] cores;

        public static void setup(uint megabytes, byte coreCount) {
            systemRam = new byte[megabytes * 1000000];
            cores = new cpuCore[coreCount];
        }

        public class cpuCore {

            public List<threadinfo> coreThreads = new List<threadinfo>();

            public struct threadinfo {
                public ulong pcounter;

                public ulong memstart;
                public ulong memmax;

                public ulong stackPointer;
                public ulong stackMax;

                public ulong status;

                public bool active;
            }
        }
    }
}
