﻿
namespace SV.UPnPLite.Extensions
{
    using System;

    public static class ObjectExtenstions
    {
        public static void EnsureNotNull(this object obj, string name)
        {            
            if (obj == null)
            {
                throw new ArgumentNullException(name);
            }

            if (obj is string)
            {
                if (string.IsNullOrEmpty((string)obj))
                {
                    throw new ArgumentNullException(name);
                }
            }                        
        }
    }
}