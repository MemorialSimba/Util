﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Util.Ui.Configs {
    /// <summary>
    /// 配置
    /// </summary>
    public class Config : IConfig {
        /// <summary>
        /// 类
        /// </summary>
        private readonly List<string> _classList;

        /// <summary>
        /// 初始化配置
        /// </summary>
        public Config() : this( new TagHelperAttributeList(), new TagHelperAttributeList(), null ) {
        }

        /// <summary>
        /// 初始化配置
        /// </summary>
        /// <param name="attributes">属性集合</param>
        /// <param name="otherAttributes">其它属性集合</param>
        /// <param name="content">内容</param>
        public Config( TagHelperAttributeList attributes, TagHelperAttributeList otherAttributes, IHtmlContent content ) {
            _classList = new List<string>();
            Attributes = attributes;
            OtherAttributes = otherAttributes;
            Content = content;
        }

        /// <summary>
        /// 属性集合
        /// </summary>
        public TagHelperAttributeList Attributes { get; }

        /// <summary>
        /// 其它属性集合
        /// </summary>
        public TagHelperAttributeList OtherAttributes { get; }

        /// <summary>
        /// 内容
        /// </summary>
        public IHtmlContent Content { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 占位符
        /// </summary>
        public string Placeholder { get; set; }

        /// <summary>
        /// 必填项
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// 必填项错误消息
        /// </summary>
        public string RequiredMessage { get; set; }

        /// <summary>
        /// 最小长度
        /// </summary>
        public int MinLength { get; set; }

        /// <summary>
        /// 最小长度错误消息
        /// </summary>
        public string MinLengthMessage { get; set; }

        /// <summary>
        /// 模型
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 属性集合是否包含指定属性
        /// </summary>
        /// <param name="name">属性名</param>
        public bool Contains( string name ) {
            return Attributes.ContainsName( name );
        }

        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <param name="name">属性名</param>
        public string GetValue( string name ) {
            return Contains( name ) ? Attributes[name].Value.SafeString() : string.Empty;
        }

        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="name">属性名</param>
        public T GetValue<T>( string name ) {
            return Util.Helpers.Convert.To<T>( GetValue( name ) );
        }

        /// <summary>
        /// 设置属性
        /// </summary>
        /// <param name="name">属性名</param>
        /// <param name="value">值</param>
        public void SetAttribute( string name,object value ) {
            Attributes.SetAttribute( new TagHelperAttribute( name,value ) );
        }

        /// <summary>
        /// 移除属性
        /// </summary>
        /// <param name="name">属性名</param>
        public void Remove( string name ) {
            Attributes.RemoveAll( name );
        }

        /// <summary>
        /// 添加类
        /// </summary>
        public void AddClass( string @class ) {
            if( string.IsNullOrWhiteSpace( @class ) )
                return;
            if( _classList.Contains( @class ) )
                return;
            _classList.Add( @class );
        }

        /// <summary>
        /// 获取类列表
        /// </summary>
        public List<string> GetClassList() {
            return _classList;
        }
    }
}
