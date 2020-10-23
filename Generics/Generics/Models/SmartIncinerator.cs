using System;

namespace Generics
{
    public class SmartIncinerator<T>
    {
        public Action<T> DestroyMethod { get; }

        public void Burn(T burnable)
        {
            DestroyMethod(burnable);
        }
    }
}
