using System;

namespace Training_Songs
{
    internal interface IItem
    {
        Guid Id { get; }
        Artist Artist { get; }
        string Name { get; set; }

    }
}