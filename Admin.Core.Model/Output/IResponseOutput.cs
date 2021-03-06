﻿using System.Text.Json.Serialization;

namespace Admin.Core.Model.Output
{
    /// <summary>
    /// 输出数据接口
    /// </summary>
    public interface IResponseOutput
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonIgnore]
        bool Success { get; }
    }

    /// <summary>
    /// 响应数据泛型接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IResponseOutput<T> : IResponseOutput
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        T Data { get; }
    }
}
