using System;

namespace Training_Song
{
    internal interface IItem
    {
        Guid Id { get; }
        Artist Artist { get; }
        string Name { get; set; }

    }
}