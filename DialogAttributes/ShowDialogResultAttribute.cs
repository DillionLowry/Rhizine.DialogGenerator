﻿using System;

namespace Rhizine.DialogAttributes
{
    public enum DialogType
    {
        Bubble,
        Toast,
        Modal,
        MessageBox,
        Input,
        Confirmation,
        YesNo,
        OpenFile,
        SaveFile,
        OpenFolder,
        Snackbar
    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ShowBubbleResultAttribute : Attribute
    {
        public DialogType Type { get; set; } = DialogType.Bubble;
        public string SuccessMessage { get; set; } = "Success!";
        public string FailureMessage { get; set; } = "Failed!";
        public int Duration { get; set; } = 2000; // milliseconds
        public string Position { get; set; } = "Center";
        public string Theme { get; set; } = "Default";


        public ShowBubbleResultAttribute() { }

        public ShowBubbleResultAttribute(string successMessage, string failureMessage)
        {
            SuccessMessage = successMessage;
            FailureMessage = failureMessage;
        }
    }
}