// Copyright 2024 SoftFuzz
//
// Licensed under the Apache License, Version 2.0 (the "License"):
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Avalonia.Controls;
using Avalonia.Input;

namespace ProfHeat.AUI.Views;

public partial class MainWindow : Window
{
    public MainWindow() => InitializeComponent();
    // Data Context for a MainWindow is set in app.xaml.cs

    private void DragWindow_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (sender is Window window && e.GetCurrentPoint(window).Properties.IsLeftButtonPressed)
        {
            BeginMoveDrag(e);
        }
    }
}
