// <copyright file="Libraries.Interfaces.Generated.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

/// <summary>
/// This file is auto-generated by a build task. It shouldn't be edited by hand.
/// </summary>
namespace SmallBasic.Compiler.Runtime
{
    using System;
    using System.Threading.Tasks;

    public interface IArrayLibrary
    {
        bool ContainsIndex(ArrayValue array, string index);

        bool ContainsValue(ArrayValue array, string value);

        ArrayValue GetAllIndices(ArrayValue array);

        decimal GetItemCount(ArrayValue array);

        BaseValue GetValue(string arrayName, string index);

        bool IsArray(BaseValue array);

        void RemoveValue(string arrayName, string index);

        void SetValue(string arrayName, string index, BaseValue value);
    }

    public interface IClockLibrary
    {
        string Get_Date();

        decimal Get_Day();

        decimal Get_ElapsedMilliseconds();

        decimal Get_Hour();

        decimal Get_Millisecond();

        decimal Get_Minute();

        decimal Get_Month();

        decimal Get_Second();

        string Get_Time();

        string Get_WeekDay();

        decimal Get_Year();
    }

    public interface IControlsLibrary
    {
        event Action ButtonClicked;

        event Action TextTyped;

        string Get_LastClickedButton();

        string Get_LastTypedTextBox();

        string AddButton(string caption, decimal left, decimal top);

        string AddMultiLineTextBox(decimal left, decimal top);

        string AddTextBox(decimal left, decimal top);

        string GetButtonCaption(string buttonName);

        string GetTextBoxText(string textBoxName);

        void HideControl(string controlName);

        void Move(string control, decimal x, decimal y);

        void Remove(string controlName);

        void SetButtonCaption(string buttonName, string caption);

        void SetSize(string control, decimal width, decimal height);

        void SetTextBoxText(string textBoxName, string text);

        void ShowControl(string controlName);
    }

    public interface IDesktopLibrary
    {
    }

    public interface IDictionaryLibrary
    {
    }

    public interface IFileLibrary
    {
        string Get_LastError();

        void Set_LastError(string value);

        Task<string> AppendContents(string filePath, string contents);

        Task<string> CopyFile(string sourceFilePath, string destinationFilePath);

        Task<string> CreateDirectory(string directoryPath);

        Task<string> DeleteDirectory(string directoryPath);

        Task<string> DeleteFile(string filePath);

        Task<BaseValue> GetDirectories(string directoryPath);

        Task<BaseValue> GetFiles(string directoryPath);

        Task<BaseValue> GetTemporaryFilePath();

        Task<string> InsertLine(string filePath, decimal lineNumber, string contents);

        Task<BaseValue> ReadContents(string filePath);

        Task<BaseValue> ReadLine(string filePath, decimal lineNumber);

        Task<string> WriteContents(string filePath, string contents);

        Task<string> WriteLine(string filePath, decimal lineNumber, string contents);
    }

    public interface IFlickrLibrary
    {
    }

    public interface IGraphicsWindowLibrary
    {
        event Action KeyDown;

        event Action KeyUp;

        event Action MouseDown;

        event Action MouseMove;

        event Action MouseUp;

        event Action TextInput;

        string Get_BackgroundColor();

        void Set_BackgroundColor(string value);

        string Get_BrushColor();

        void Set_BrushColor(string value);

        bool Get_FontBold();

        void Set_FontBold(bool value);

        bool Get_FontItalic();

        void Set_FontItalic(bool value);

        string Get_FontName();

        void Set_FontName(string value);

        decimal Get_FontSize();

        void Set_FontSize(decimal value);

        Task<decimal> Get_Height();

        string Get_LastKey();

        string Get_LastText();

        decimal Get_MouseX();

        decimal Get_MouseY();

        string Get_PenColor();

        void Set_PenColor(string value);

        decimal Get_PenWidth();

        void Set_PenWidth(decimal value);

        Task<decimal> Get_Width();

        void Clear();

        void DrawBoundText(decimal x, decimal y, decimal width, string text);

        void DrawEllipse(decimal x, decimal y, decimal width, decimal height);

        void DrawImage(string imageName, decimal x, decimal y);

        void DrawLine(decimal x1, decimal y1, decimal x2, decimal y2);

        void DrawRectangle(decimal x, decimal y, decimal width, decimal height);

        void DrawResizedImage(string imageName, decimal x, decimal y, decimal width, decimal height);

        void DrawText(decimal x, decimal y, string text);

        void DrawTriangle(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3);

        void FillEllipse(decimal x, decimal y, decimal width, decimal height);

        void FillRectangle(decimal x, decimal y, decimal width, decimal height);

        void FillTriangle(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3);

        string GetColorFromRGB(decimal red, decimal green, decimal blue);

        string GetRandomColor();

        void Hide();

        void SetPixel(decimal x, decimal y, string color);

        void Show();

        Task ShowMessage(string text, string title);
    }

    public interface IImageListLibrary
    {
        decimal GetHeightOfImage(string imageName);

        decimal GetWidthOfImage(string imageName);

        Task<string> LoadImage(string fileNameOrUrl);
    }

    public interface IMathLibrary
    {
        decimal Get_Pi();

        decimal Abs(decimal number);

        decimal ArcCos(decimal cosValue);

        decimal ArcSin(decimal sinValue);

        decimal ArcTan(decimal tanValue);

        decimal Ceiling(decimal number);

        decimal Cos(decimal angle);

        decimal Floor(decimal number);

        decimal GetDegrees(decimal angle);

        decimal GetRadians(decimal angle);

        decimal GetRandomNumber(decimal maxNumber);

        decimal Log(decimal number);

        decimal Max(decimal number1, decimal number2);

        decimal Min(decimal number1, decimal number2);

        decimal NaturalLog(decimal number);

        decimal Power(decimal baseNumber, decimal exponent);

        decimal Remainder(decimal dividend, decimal divisor);

        decimal Round(decimal number);

        decimal Sin(decimal angle);

        decimal SquareRoot(decimal number);

        decimal Tan(decimal angle);
    }

    public interface IMouseLibrary
    {
        bool Get_IsLeftButtonDown();

        bool Get_IsRightButtonDown();

        decimal Get_MouseX();

        decimal Get_MouseY();

        void HideCursor();

        void ShowCursor();
    }

    public interface INetworkLibrary
    {
        Task<string> DownloadFile(string url);

        Task<string> GetWebPageContents(string url);
    }

    public interface IProgramLibrary
    {
        Task Delay(decimal milliSeconds);

        void End();

        void Pause();
    }

    public interface IShapesLibrary
    {
        string AddEllipse(decimal width, decimal height);

        string AddImage(string imageName);

        string AddLine(decimal x1, decimal y1, decimal x2, decimal y2);

        string AddRectangle(decimal width, decimal height);

        string AddText(string text);

        string AddTriangle(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3);

        Task Animate(string shapeName, decimal x, decimal y, decimal duration);

        decimal GetLeft(string shapeName);

        decimal GetOpacity(string shapeName);

        decimal GetTop(string shapeName);

        void HideShape(string shapeName);

        void Move(string shapeName, decimal x, decimal y);

        void Remove(string shapeName);

        void Rotate(string shapeName, decimal angle);

        void SetOpacity(string shapeName, decimal level);

        void SetText(string shapeName, string text);

        void ShowShape(string shapeName);

        void Zoom(string shapeName, decimal scaleX, decimal scaleY);
    }

    public interface ISoundLibrary
    {
    }

    public interface IStackLibrary
    {
        decimal GetCount(string stackName);

        string PopValue(string stackName);

        void PushValue(string stackName, string value);
    }

    public interface ITextLibrary
    {
        string Append(string text1, string text2);

        string ConvertToLowerCase(string text);

        string ConvertToUpperCase(string text);

        bool EndsWith(string text, string subText);

        string GetCharacter(decimal characterCode);

        decimal GetCharacterCode(string character);

        decimal GetIndexOf(string text, string subText);

        decimal GetLength(string text);

        string GetSubText(string text, decimal start, decimal length);

        string GetSubTextToEnd(string text, decimal start);

        bool IsSubText(string text, string subText);

        bool StartsWith(string text, string subText);
    }

    public interface ITextWindowLibrary
    {
        string Get_BackgroundColor();

        void Set_BackgroundColor(string value);

        string Get_ForegroundColor();

        void Set_ForegroundColor(string value);

        void Clear();

        string Read();

        decimal ReadNumber();

        Task Write(string data);

        Task WriteLine(string data);
    }

    public interface ITimerLibrary
    {
        event Action Tick;

        decimal Get_Interval();

        void Set_Interval(decimal value);

        void Pause();

        void Resume();
    }

    public interface ITurtleLibrary
    {
        decimal Get_Angle();

        void Set_Angle(decimal value);

        decimal Get_Speed();

        void Set_Speed(decimal value);

        decimal Get_X();

        void Set_X(decimal value);

        decimal Get_Y();

        void Set_Y(decimal value);

        void Hide();

        Task Move(decimal distance);

        Task MoveTo(decimal x, decimal y);

        void PenDown();

        void PenUp();

        void Show();

        Task Turn(decimal angle);

        Task TurnLeft();

        Task TurnRight();
    }

    public interface IEngineLibraries
    {
        IArrayLibrary Array { get; }

        IClockLibrary Clock { get; }

        IControlsLibrary Controls { get; }

        IDesktopLibrary Desktop { get; }

        IDictionaryLibrary Dictionary { get; }

        IFileLibrary File { get; }

        IFlickrLibrary Flickr { get; }

        IGraphicsWindowLibrary GraphicsWindow { get; }

        IImageListLibrary ImageList { get; }

        IMathLibrary Math { get; }

        IMouseLibrary Mouse { get; }

        INetworkLibrary Network { get; }

        IProgramLibrary Program { get; }

        IShapesLibrary Shapes { get; }

        ISoundLibrary Sound { get; }

        IStackLibrary Stack { get; }

        ITextLibrary Text { get; }

        ITextWindowLibrary TextWindow { get; }

        ITimerLibrary Timer { get; }

        ITurtleLibrary Turtle { get; }
    }

    internal static class IEngineLibrariesExtensions
    {
        public static void SetEventCallbacks(this IEngineLibraries libraries, SmallBasicEngine engine)
        {
            libraries.Controls.ButtonClicked += () => engine.RaiseEvent("Controls", "ButtonClicked");
            libraries.Controls.TextTyped += () => engine.RaiseEvent("Controls", "TextTyped");

            libraries.GraphicsWindow.KeyDown += () => engine.RaiseEvent("GraphicsWindow", "KeyDown");
            libraries.GraphicsWindow.KeyUp += () => engine.RaiseEvent("GraphicsWindow", "KeyUp");
            libraries.GraphicsWindow.MouseDown += () => engine.RaiseEvent("GraphicsWindow", "MouseDown");
            libraries.GraphicsWindow.MouseMove += () => engine.RaiseEvent("GraphicsWindow", "MouseMove");
            libraries.GraphicsWindow.MouseUp += () => engine.RaiseEvent("GraphicsWindow", "MouseUp");
            libraries.GraphicsWindow.TextInput += () => engine.RaiseEvent("GraphicsWindow", "TextInput");

            libraries.Timer.Tick += () => engine.RaiseEvent("Timer", "Tick");
        }
    }
}
