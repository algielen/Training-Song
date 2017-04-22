using System;

namespace Training_Song
{
    internal interface INamedItem : IPlayableItem
    {
        Guid Id { get; }
        Artist Artist { get; }
        string Name { get; set; }
    }
}