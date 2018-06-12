﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ytg.BasicModel;

namespace Ytg.Core.Service
{
    public interface IEnbService<T> where T : EnaEntity
    {
        IQueryable<T> Where(Expression<Func<T, bool>> predicate, bool isEnabled = true);

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// 还原，恢复为启用状态
        /// </summary>
        /// <param name="o"></param>
        void Restore(T o);

        /// <summary>
        /// 禁用
        /// </summary>
        /// <param name="o"></param>
        void Disabled(T o);
    }
}