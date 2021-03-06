﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGame
{
    struct GameConstants
    {
        public const int WINDOW_WIDTH = 1000;
        public const int WINDOW_HEIGHT = 750;
        public const int ACTION_BAR_HEIGHT = 50;

        public const int TILE_SIZE = 50;
        public const int TILES_WIDE = WINDOW_WIDTH / TILE_SIZE;
        public const int TILES_HIGH = WINDOW_HEIGHT / TILE_SIZE;

        public const int PLAYER_MAX_HIT_POINTS = 100;
        public const float PLAYER_BASE_SPEED = 0.35f;

        public const int NUMBER_OF_SAVES = 5;

        public const int NUMBER_OF_ROCKS = 30;
        public const int SAFE_ZONE_SIZE = 10; //In tiles. Area in which enemies cannot spawn

        public const int PAUSE_DELAY = 1500;

        public const bool GOD_MODE = false;
    }
}
