using System;

namespace CTItemSystem
{
    public class CTItemSize
    {
        private Tuple<int, int> size;

        public CTItemSize(int width, int height) => size = new Tuple<int, int>(width, height);

        public Tuple<int, int> Size => size;
    }
}
