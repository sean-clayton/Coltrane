using System;

namespace CTItemSystem
{
    public class CTItemSize
    {
        private Tuple<int, int> size;

        public CTItemSize(int width = 1, int height = 1) => size = new Tuple<int, int>(width, height);

        public Tuple<int, int> Size => size;
    }
}
