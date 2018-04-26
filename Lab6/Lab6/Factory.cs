using System;

namespace Lab6
{
    interface IFactory<out T>
    {
        T Create();
    }
}
