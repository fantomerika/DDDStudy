﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Undefine.Infrastructure.Extension
{
    public static class DistinctExtensions
    {
        /// <summary>
        /// 去重
        /// </summary>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();
            return source.Where(element => seenKeys.Add(keySelector(element)));
        }

        //public void test()
        //{
        //    List<int> a=new List<int>(){1,2,3};
        //    //DistinctBy<int,int>()
        //}
    }
}
