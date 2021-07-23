﻿using Rampastring.XNAUI.XNAControls;
using System.Collections.Generic;
using TSMapEditor.Models;
using TSMapEditor.UI.Controls;

namespace TSMapEditor.UI.Windows
{
    public class WindowController
    {
        private List<EditorWindow> Windows { get; } = new List<EditorWindow>();

        public TaskforcesWindow TaskForcesWindow { get; private set; }

        public void Initialize(XNAControl windowParentControl, Map map)
        {
            TaskForcesWindow = new TaskforcesWindow(windowParentControl.WindowManager, map);
            Windows.Add(TaskForcesWindow);

            foreach (var window in Windows)
            {
                windowParentControl.AddChild(window);
                window.Disable();
                window.CenterOnParent();
            }
        }
    }
}
