﻿using Util.Ui.Components;
using Util.Ui.Material.Buttons.Renders;
using Util.Ui.Renders;

namespace Util.Ui.Material.Buttons {
    /// <summary>
    /// 按钮
    /// </summary>
    public class Button : ComponentBase, IButton {
        /// <summary>
        /// 获取渲染器
        /// </summary>
        protected override IRender GetRender() {
            return new ButtonRender( OptionConfig );
        }
    }
}
