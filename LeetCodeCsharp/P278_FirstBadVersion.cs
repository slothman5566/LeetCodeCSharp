using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P278_FirstBadVersion
{
    public class VersionControl
    {
        private List<bool> _Version;
        public void Init(int length, int pos)
        {
            _Version = new List<bool>();
            for (var i = 0; i < length; i++)
            {
                if (i >= pos)
                {
                    _Version.Add(true);
                }
                else
                {
                    _Version.Add(false);
                }
            }
        }
        protected bool IsBadVersion(int n)
        {

            return _Version[n - 1];
        }
    }
    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            var left = 1;
            var right = n;

            while (left < right)
            {
                // overflow
                var mid = left + (right - left) / 2;

                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}
