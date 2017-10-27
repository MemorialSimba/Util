﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Util.Ui.Configs {
    /// <summary>
    /// 基础配置
    /// </summary>
    public interface IConfig {
        /// <summary>
        /// 属性集合
        /// </summary>
        TagHelperAttributeList Attributes { get; }
        /// <summary>
        /// 其它属性集合
        /// </summary>
        TagHelperAttributeList OtherAttributes { get; }
        /// <summary>
        /// 内容
        /// </summary>
        IHtmlContent Content { get; set; }
        /// <summary>
        /// 属性集合是否包含指定属性
        /// </summary>
        /// <param name="name">属性名</param>
        bool Contains( string name );
        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <param name="name">属性名</param>
        string GetValue( string name );
        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="name">属性名</param>
        T GetValue<T>( string name );
        /// <summary>
        /// 设置属性
        /// </summary>
        /// <param name="name">属性名</param>
        /// <param name="value">值</param>
        void SetAttribute( string name, object value );
        /// <summary>
        /// 移除属性
        /// </summary>
        /// <param name="name">属性名</param>
        void Remove( string name );
        /// <summary>
        /// 添加类
        /// </summary>
        void AddClass( string @class );
        /// <summary>
        /// 获取类列表
        /// </summary>
        List<string> GetClassList();
    }
}
