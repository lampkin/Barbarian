﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Barbarian.Win.Animation
{
    public interface IDrawable
    {
        bool IsActive { get; }
        void Draw(GameTime gameTime);
    }
}
