using System;

namespace clcpu_64 {
    public static class Program {
        [STAThread]
        static void Main(string[] args) {
            using Game1 game = new Game1();
            game.args = args;
            game.Run();
        }
    }
}
