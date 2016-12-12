﻿using System;
using System.Collections.Generic;
using System.Linq;
using JJ.Data.Canonical;
using JJ.Framework.PlatformCompatibility;
using JJ.Framework.Exceptions;

namespace JJ.Business.Canonical
{
    public static class MessageHelper
    {
        public static string FormatMessages(IList<Message> messages)
        {
            if (messages == null) throw new NullException(() => messages);

            string formattedMessages = String_PlatformSupport.Join(Environment.NewLine, messages.Select(x => x.Text));
            return formattedMessages;
        }
    }
}