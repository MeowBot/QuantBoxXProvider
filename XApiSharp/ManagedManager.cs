﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace QuantBox.XApi
{
    internal static class ManagedManager
    {
        private static readonly Dictionary<string, Type> Loaded = new Dictionary<string, Type>();
        private static readonly object Locker = new object();

        private static Assembly GetAssembly(string path)
        {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) {
                try {
                    if (asm.Location == path) {
                        return asm;
                    }
                }
                catch (Exception) {
                }
            }
            return Assembly.LoadFile(path);
        }

        private static Type GetApiType(string path)
        {
            Loaded.TryGetValue(path, out Type exist);
            if (exist == null) {
                var asm = GetAssembly(path);
                foreach (var type in asm.ExportedTypes) {
                    if (typeof(IXApi).IsAssignableFrom(type)) {
                        Loaded.Add(path, type);
                        exist = type;
                        break;
                    }
                }
            }
            return exist;
        }

        public static object GetInstance(string path)
        {
            lock (Locker) {
                var type = GetApiType(path);
                if (type == null) {
                    throw new InvalidOperationException("XApi tpye not found.");
                }
                return Activator.CreateInstance(type);
            }
        }
    }
}