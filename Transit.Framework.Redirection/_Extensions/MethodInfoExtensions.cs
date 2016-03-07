﻿using System;
using System.Reflection;

namespace Transit.Framework.Redirection
{
    public static class MethodInfoExtensions
    {
        internal static Redirector.MethodRedirection RedirectTo(this MethodInfo originalMethod, MethodInfo newMethod, Assembly redirectionSource, ulong bitSetOption)
        {
            return new Redirector.MethodRedirection(originalMethod, newMethod, redirectionSource, bitSetOption);
        }

        public static bool IsCompatibleWith(this MethodInfo thisMethod, MethodInfo otherMethod)
        {
            if (thisMethod.ReturnType != otherMethod.ReturnType)
                return false;

            ParameterInfo[] thisParameters = thisMethod.GetParameters();
            ParameterInfo[] otherParameters = otherMethod.GetParameters();

            if (thisParameters.Length != otherParameters.Length)
                return false;

            for (int i = 0; i < thisParameters.Length; i++)
            {
                if (!otherParameters[i].ParameterType.IsAssignableFrom(thisParameters[i].ParameterType))
                {
                    return false;
                }
            }

            return true;
        }
    }
}