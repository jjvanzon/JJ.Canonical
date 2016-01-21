﻿using System;
using System.Collections.Generic;
using System.Linq;
using JJ.Data.Canonical;
using JJ.Framework.PlatformCompatibility;
using JJ.Framework.Reflection.Exceptions;

namespace JJ.Business.Canonical
{
    public static class ResultHelper
    {
        public static void Assert(IResult result)
        {
            if (result == null) throw new NullException(() => result);

            if (!result.Successful)
            {
                string formattedMessages = FormatMessages(result);
                throw new Exception(formattedMessages);
            }
        }

        public static string FormatMessages(IResult result)
        {
            if (result == null) throw new NullException(() => result);

            string formattedMessages = MessageHelper.FormatMessages(result.Messages);
            return formattedMessages;
        }

        public static IResult Combine(params IResult[] results)
        {
            if (results == null) throw new NullException(() => results);

            IResult result = new VoidResult
            {
                Successful = true
            };

            foreach (IResult result2 in results)
            {
                result.Successful &= result2.Successful;

                foreach (Message message in result.Messages)
                {
                    result.Messages.Add(message);
                }
            }

            return result;
        }
    }
}