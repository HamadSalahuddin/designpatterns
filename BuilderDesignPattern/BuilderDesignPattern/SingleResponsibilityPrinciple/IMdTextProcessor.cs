﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public interface IMdTextProcessor: ITextProcessor
    {
        string ConvertMdText(string inputText);
    }
}
