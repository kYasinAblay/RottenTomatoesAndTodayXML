using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TodayXML.Extensions
{
    public static class DirectoryInfoExtension
    {
        public static List<DirectoryInfo> Split(this DirectoryInfo path)
        {
            if (path == null) throw new ArgumentNullException("path");
            var ret = new List<DirectoryInfo>();
            if (path.Parent != null) ret.AddRange(Split(path.Parent));
            ret.Add(path);
            return ret;
        }
    }


}
