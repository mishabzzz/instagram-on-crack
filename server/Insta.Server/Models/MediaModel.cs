﻿using System.Collections.Generic;
using InstaSharp.Models;

namespace Insta.Server.Models
{
    public class MediaModel
    { 
        public Media Media { get; set; }
        public IEnumerable<string> Data { get; set; }
    }
}