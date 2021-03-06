﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeCell.Bricks.AppFramework;

namespace CodeCell.AgileMap.ToolBox
{
    public class cmdCut : BaseCommand
    {
        public cmdCut()
        {
            Init();
        }

        public cmdCut(bool beginGroup)
            : base(beginGroup)
        {
            Init();
        }

        private void Init()
        {
            _text = "剪切";
            _tooltips = _text;
            _image = ResourceLoader.GetBitmap("cmdCut.png");
        }
    }
}
