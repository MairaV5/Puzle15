﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzle15
{
    class PuzzleBlock : Button
    {
        public PuzzleBlock()
        {
            InitializePuzzleBlock();
        }

        private void InitializePuzzleBlock()
        {
            this.BackColor = Color.DeepSkyBlue;
            this.Height = 80;
            this.Width = 80;
            this.Text = "0";
            this.Font = new Font("Roboto", 18);
        }
    }
}
