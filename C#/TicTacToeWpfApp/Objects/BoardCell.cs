﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWpfApp.Objects
{
    class BoardCell
    {
        public Position Position { get; set; } = new();

        public string SettedPlayer { get; set; }
    }
}
