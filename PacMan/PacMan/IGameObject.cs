using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PacMan1
{
    public interface IGameObject
    {
        Vector Position { get; }

        char Symbol { get; }
    }
}

