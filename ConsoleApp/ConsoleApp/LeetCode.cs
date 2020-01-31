using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp
{
    class LeetCode
    {
        /// <summary>
        /// 给定一个整数数组，返回两个数字的索引，以便它们加起来成为一个特定的目标
        /// </summary>
        /// <param name="nums">整型数组</param>
        /// <param name="target">目标值，类型为整型</param>
        /// <returns>符合条件的索引，类型为整型数组</returns>
        public static int[] TwoSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length - 1; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == target) {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ApplicationException("No two sum solution");
        }

        /// <summary>
        /// 给定一个整数数组，返回两个数字的索引，以便它们加起来成为一个特定的目标
        /// </summary>
        /// <param name="nums">整型数组</param>
        /// <param name="target">目标值，类型为整型</param>
        /// <returns>符合条件的索引，类型为整型数组</returns>
        public static int[] TwoSum2(int[] nums, int target)
        {
            // 哈希表 
            //  - 键 => 数组各值
            //  - 值 => 数组各值对应索引
            Hashtable map = new Hashtable();
            for(int i = 0; i < nums.Length; i++) {
                map.Add(nums[i], i);
            }
            for(int i = 0; i < nums.Length; i++) {
                int complement = target - nums[i];
                if(map.ContainsKey(complement) && Convert.ToInt32(map[complement]) != i) {
                    return new int[] { i, Convert.ToInt32(map[complement]) };
                }
            }
            throw new ApplicationException("No two sum solution");
        }

        /// <summary>
        /// 给定一个整数数组，返回两个数字的索引，以便它们加起来成为一个特定的目标
        /// </summary>
        /// <param name="nums">整型数组</param>
        /// <param name="target">目标值，类型为整型</param>
        /// <returns>符合条件的索引，类型为整型数组</returns>
        public static int[] TwoSum3(int[] nums, int target)
        {
            Hashtable map = new Hashtable();
            for(int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { i, Convert.ToInt32(map[complement]) };
                }
                map.Add(nums[i], i);
            }
            throw new ApplicationException("No two sum solution");
        }
    }
}
