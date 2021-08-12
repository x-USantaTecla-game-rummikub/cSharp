﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rummy.controllers;

namespace Rummy.models.interpreter
{
    public class ResumeCommand : Command
    {
        public override void execute(PlayController playController)
        {
            playController.resume();
        }
    }
}