﻿using System;

namespace Xfrogcn.PluginFactory
{
    /// <summary>
    /// 插件信息
    /// </summary>
    public class PluginInfo
    {
        /// <summary>
        /// 插件Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 插件名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 插件描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsEnable { get; set; } = true;

        /// <summary>
        /// 插件类型
        /// </summary>
        public Type PluginType { get; set; }

        /// <summary>
        /// 是否可以配置
        /// </summary>
        public bool CanConfig { get; set; }

        /// <summary>
        /// 是否支持Init
        /// </summary>
        public bool CanInit { get; set; }

        /// <summary>
        /// 配置类型
        /// </summary>
        public Type ConfigType { get; set; }

        /// <summary>
        /// 插件顺序
        /// </summary>
        public int Order { get; set; }
    }
}
