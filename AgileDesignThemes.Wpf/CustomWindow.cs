using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shell;

namespace AgileDesignThemes.Wpf
{
    public class CustomWindow : Window
    {
        public CustomWindow()
        {
            var chrome = new WindowChrome
            {
                GlassFrameThickness = new Thickness(1),
                ResizeBorderThickness = new Thickness(4)
            };
            WindowChrome.SetWindowChrome(this, chrome);

            //将标题栏高度绑定给Chrome
            BindingOperations.SetBinding(chrome, WindowChrome.CaptionHeightProperty,
                new Binding(CaptionHeightProperty.Name) { Source = this });
            BindSystemBindings();
        }


        #region Methods
        /// <summary>
        /// 绑定系统命令
        /// </summary>
        private void BindSystemBindings()
        {
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, (sen, e) => { SystemCommands.MinimizeWindow(this); }));
            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, (sen, e) => { SystemCommands.MaximizeWindow(this); }));
            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, (sen, e) => { SystemCommands.CloseWindow(this); }));
            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, (sen, e) => { SystemCommands.RestoreWindow(this); }));
        }
        #endregion

        #region Property

        #region 标题栏按钮属性
        public static readonly DependencyProperty ButtonHeightProperty = DependencyProperty.Register(
         "ButtonHeight", typeof(double), typeof(CustomWindow), new PropertyMetadata(30.0));
        /// <summary>
        /// 系统按钮高度
        /// </summary>
        public double ButtonHeight
        {
            get => (double)GetValue(ButtonHeightProperty);
            set => SetValue(ButtonHeightProperty, value);
        }

        public static readonly DependencyProperty ButtonWidthProperty = DependencyProperty.Register(
            "ButtonWidth", typeof(double), typeof(CustomWindow), new PropertyMetadata(35.0));
        /// <summary>
        /// 系统按钮宽度
        /// </summary>
        public double ButtonWidth
        {
            get => (double)GetValue(ButtonWidthProperty);
            set => SetValue(ButtonWidthProperty, value);
        }

        public static readonly DependencyProperty ButtonForegroundProperty = DependencyProperty.Register(
            "ButtonForeground", typeof(Brush), typeof(CustomWindow), new PropertyMetadata(default(Brush)));
        /// <summary>
        /// 系统按钮前景色
        /// </summary>
        public Brush ButtonForeground
        {
            get => (Brush)GetValue(ButtonForegroundProperty);
            set => SetValue(ButtonForegroundProperty, value);
        }

        public static readonly DependencyProperty ButtonBackgroundProperty = DependencyProperty.Register(
            "ButtonBackground", typeof(Brush), typeof(CustomWindow), new PropertyMetadata(default(Brush)));
        /// <summary>
        /// 系统按钮背景色
        /// </summary>
        public Brush ButtonBackground
        {
            get => (Brush)GetValue(ButtonBackgroundProperty);
            set => SetValue(ButtonBackgroundProperty, value);
        }

        #endregion

        #region 窗口属性
        /// <summary>
        /// 标题栏高度
        /// </summary>
        public double CaptionHeight
        {
            get => (double)GetValue(CaptionHeightProperty);
            set => SetValue(CaptionHeightProperty, value);
        }
        public static readonly DependencyProperty CaptionHeightProperty = DependencyProperty.Register(
            "CaptionHeight", typeof(double), typeof(CustomWindow), new PropertyMetadata(30.0));
        /// <summary>
        /// 标题栏背景色
        /// </summary>
        public Brush CaptionBackground
        {
            get => (Brush)GetValue(CaptionBackgroundProperty);
            set => SetValue(CaptionBackgroundProperty, value);
        }

        public static readonly DependencyProperty CaptionBackgroundProperty = DependencyProperty.Register(
            "CaptionBackground", typeof(Brush), typeof(CustomWindow), new PropertyMetadata(default(Brush)));

        public static readonly DependencyProperty TitleContentProperty = DependencyProperty.Register(
            "TitleContent", typeof(UIElement), typeof(CustomWindow), new PropertyMetadata(default(UIElement)));
        /// <summary>
        /// 标题栏内容
        /// </summary>
        public UIElement TitleContent
        {
            get => (UIElement)GetValue(TitleContentProperty);
            set => SetValue(TitleContentProperty, value);
        }

        public static readonly DependencyProperty FitSystemWindowProperty = DependencyProperty.Register(
            "FitSystemWindow", typeof(bool), typeof(CustomWindow), new PropertyMetadata(default(bool),
                (sen, args) =>
                {
                    //var win = sen as CustomWindow;
                    //if (args.NewValue is (true))
                    //{
                    //    _tempCaptionColor = win.CaptionBackground;
                    //    win.CaptionBackground = win.Background;
                    //}
                    //else
                    //{
                    //    if (_tempCaptionColor is not null)
                    //        win.CaptionBackground = _tempCaptionColor;
                    //}


                }));
        /// <summary>
        /// 沉浸式标题栏
        /// </summary>
        public bool FitSystemWindow
        {
            get => (bool)GetValue(FitSystemWindowProperty);
            set => SetValue(FitSystemWindowProperty, value);
        }
        #endregion
        #endregion

    }
}
