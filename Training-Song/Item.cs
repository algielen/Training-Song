using System;

namespace Training_Songs
{
    internal interface Item
    {
        Guid Id { get; }
        Artist Artist { get; }
        string Name { get; set; }

    }
}