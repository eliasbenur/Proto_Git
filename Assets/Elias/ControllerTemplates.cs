// <auto-generated>
// ControllerTemplates.cs
// Generated on 3/23/2019 2:16:22 PM
// Do not edit this file.
// This file can be generated from the ControllerDataFiles inspector.
// </auto-generated>

// Copyright (c) 2018 Augie R. Maddox, Guavaman Enterprises. All rights reserved.

#if REWIRED_USE_USER_DEFINED_CONTROLLER_TEMPLATES

#pragma warning disable 0219
#pragma warning disable 0618
#pragma warning disable 0649
#pragma warning disable 0067

namespace Rewired {
    
    #region Interfaces
    
    /// <summary>
    /// Interface for a Gamepad Controller Template.
    /// </summary>
    public partial interface IGamepadTemplate : IControllerTemplate {
        
        /// <summary>
        /// The "Action Bottom Row 1" element.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 1" element.</returns>
        IControllerTemplateButton actionBottomRow1 { get; }
        
        /// <summary>
        /// The "Action Bottom Row 1" element.
        /// This is an alias for <see cref="actionBottomRow1"/>.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 1" element.</returns>
        IControllerTemplateButton a { get; }
        
        /// <summary>
        /// The "Action Bottom Row 2" element.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 2" element.</returns>
        IControllerTemplateButton actionBottomRow2 { get; }
        
        /// <summary>
        /// The "Action Bottom Row 2" element.
        /// This is an alias for <see cref="actionBottomRow2"/>.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 2" element.</returns>
        IControllerTemplateButton b { get; }
        
        /// <summary>
        /// The "Action Bottom Row 3" element.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 3" element.</returns>
        IControllerTemplateButton actionBottomRow3 { get; }
        
        /// <summary>
        /// The "Action Bottom Row 3" element.
        /// This is an alias for <see cref="actionBottomRow3"/>.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 3" element.</returns>
        IControllerTemplateButton c { get; }
        
        /// <summary>
        /// The "Action Top Row 1" element.
        /// </summary>
        /// <returns>Returns the "Action Top Row 1" element.</returns>
        IControllerTemplateButton actionTopRow1 { get; }
        
        /// <summary>
        /// The "Action Top Row 1" element.
        /// This is an alias for <see cref="actionTopRow1"/>.
        /// </summary>
        /// <returns>Returns the "Action Top Row 1" element.</returns>
        IControllerTemplateButton x { get; }
        
        /// <summary>
        /// The "Action Top Row 2" element.
        /// </summary>
        /// <returns>Returns the "Action Top Row 2" element.</returns>
        IControllerTemplateButton actionTopRow2 { get; }
        
        /// <summary>
        /// The "Action Top Row 2" element.
        /// This is an alias for <see cref="actionTopRow2"/>.
        /// </summary>
        /// <returns>Returns the "Action Top Row 2" element.</returns>
        IControllerTemplateButton y { get; }
        
        /// <summary>
        /// The "Action Top Row 3" element.
        /// </summary>
        /// <returns>Returns the "Action Top Row 3" element.</returns>
        IControllerTemplateButton actionTopRow3 { get; }
        
        /// <summary>
        /// The "Action Top Row 3" element.
        /// This is an alias for <see cref="actionTopRow3"/>.
        /// </summary>
        /// <returns>Returns the "Action Top Row 3" element.</returns>
        IControllerTemplateButton z { get; }
        
        /// <summary>
        /// The "Left Shoulder 1" element.
        /// </summary>
        /// <returns>Returns the "Left Shoulder 1" element.</returns>
        IControllerTemplateButton leftShoulder1 { get; }
        
        /// <summary>
        /// The "Left Shoulder 1" element.
        /// This is an alias for <see cref="leftShoulder1"/>.
        /// </summary>
        /// <returns>Returns the "Left Shoulder 1" element.</returns>
        IControllerTemplateButton leftBumper { get; }
        
        /// <summary>
        /// The "Left Shoulder 2" element.
        /// </summary>
        /// <returns>Returns the "Left Shoulder 2" element.</returns>
        IControllerTemplateAxis leftShoulder2 { get; }
        
        /// <summary>
        /// The "Left Shoulder 2" element.
        /// This is an alias for <see cref="leftShoulder2"/>.
        /// </summary>
        /// <returns>Returns the "Left Shoulder 2" element.</returns>
        IControllerTemplateAxis leftTrigger { get; }
        
        /// <summary>
        /// The "Right Shoulder 1" element.
        /// </summary>
        /// <returns>Returns the "Right Shoulder 1" element.</returns>
        IControllerTemplateButton rightShoulder1 { get; }
        
        /// <summary>
        /// The "Right Shoulder 1" element.
        /// This is an alias for <see cref="rightShoulder1"/>.
        /// </summary>
        /// <returns>Returns the "Right Shoulder 1" element.</returns>
        IControllerTemplateButton rightBumper { get; }
        
        /// <summary>
        /// The "Right Shoulder 2" element.
        /// </summary>
        /// <returns>Returns the "Right Shoulder 2" element.</returns>
        IControllerTemplateAxis rightShoulder2 { get; }
        
        /// <summary>
        /// The "Right Shoulder 2" element.
        /// This is an alias for <see cref="rightShoulder2"/>.
        /// </summary>
        /// <returns>Returns the "Right Shoulder 2" element.</returns>
        IControllerTemplateAxis rightTrigger { get; }
        
        /// <summary>
        /// The "Center 1" element.
        /// </summary>
        /// <returns>Returns the "Center 1" element.</returns>
        IControllerTemplateButton center1 { get; }
        
        /// <summary>
        /// The "Center 1" element.
        /// This is an alias for <see cref="center1"/>.
        /// </summary>
        /// <returns>Returns the "Center 1" element.</returns>
        IControllerTemplateButton back { get; }
        
        /// <summary>
        /// The "Center 2" element.
        /// </summary>
        /// <returns>Returns the "Center 2" element.</returns>
        IControllerTemplateButton center2 { get; }
        
        /// <summary>
        /// The "Center 2" element.
        /// This is an alias for <see cref="center2"/>.
        /// </summary>
        /// <returns>Returns the "Center 2" element.</returns>
        IControllerTemplateButton start { get; }
        
        /// <summary>
        /// The "Center 3" element.
        /// </summary>
        /// <returns>Returns the "Center 3" element.</returns>
        IControllerTemplateButton center3 { get; }
        
        /// <summary>
        /// The "Center 3" element.
        /// This is an alias for <see cref="center3"/>.
        /// </summary>
        /// <returns>Returns the "Center 3" element.</returns>
        IControllerTemplateButton guide { get; }
        
        /// <summary>
        /// The "Left Stick" element.
        /// </summary>
        /// <returns>Returns the "Left Stick" element.</returns>
        IControllerTemplateThumbStick leftStick { get; }
        
        /// <summary>
        /// The "Right Stick" element.
        /// </summary>
        /// <returns>Returns the "Right Stick" element.</returns>
        IControllerTemplateThumbStick rightStick { get; }
        
        /// <summary>
        /// The "D-Pad" element.
        /// </summary>
        /// <returns>Returns the "D-Pad" element.</returns>
        IControllerTemplateDPad dPad { get; }
    }
    
    #endregion
    
    #region Classes
    
    /// <summary>
    /// Class representing a Gamepad Template.
    /// This class contains constants. Do not use this class to interact with the Rewired API. 
    /// Use the interface <see cref="IGamepadTemplate"/> instead.
    /// </summary>
    public sealed partial class GamepadTemplate : ControllerTemplate, IGamepadTemplate {
        
        /// <summary>
        /// The type Guid of the Controller Template.
        /// </summary>
        public static readonly System.Guid typeGuid = new System.Guid("83b427e4-086f-47f3-bb06-be266abd1ca5");
        
        #region Constants
        
        /// <summary>
        /// Element identifier id for "Left Stick X".
        /// </summary>
        public const int elementId_leftStickX = 0;
        
        /// <summary>
        /// Element identifier id for "Left Stick Y".
        /// </summary>
        public const int elementId_leftStickY = 1;
        
        /// <summary>
        /// Element identifier id for "Right Stick X".
        /// </summary>
        public const int elementId_rightStickX = 2;
        
        /// <summary>
        /// Element identifier id for "Right Stick Y".
        /// </summary>
        public const int elementId_rightStickY = 3;
        
        /// <summary>
        /// Element identifier id for "Action Bottom Row 1".
        /// </summary>
        public const int elementId_actionBottomRow1 = 4;
        
        /// <summary>
        /// Element identifier id for "Action Bottom Row 1".
        /// This is an alias for <see cref="elementId_actionBottomRow1"/>.
        /// </summary>
        public const int elementId_a = 4;
        
        /// <summary>
        /// Element identifier id for "Action Bottom Row 2".
        /// </summary>
        public const int elementId_actionBottomRow2 = 5;
        
        /// <summary>
        /// Element identifier id for "Action Bottom Row 2".
        /// This is an alias for <see cref="elementId_actionBottomRow2"/>.
        /// </summary>
        public const int elementId_b = 5;
        
        /// <summary>
        /// Element identifier id for "Action Bottom Row 3".
        /// </summary>
        public const int elementId_actionBottomRow3 = 6;
        
        /// <summary>
        /// Element identifier id for "Action Bottom Row 3".
        /// This is an alias for <see cref="elementId_actionBottomRow3"/>.
        /// </summary>
        public const int elementId_c = 6;
        
        /// <summary>
        /// Element identifier id for "Action Top Row 1".
        /// </summary>
        public const int elementId_actionTopRow1 = 7;
        
        /// <summary>
        /// Element identifier id for "Action Top Row 1".
        /// This is an alias for <see cref="elementId_actionTopRow1"/>.
        /// </summary>
        public const int elementId_x = 7;
        
        /// <summary>
        /// Element identifier id for "Action Top Row 2".
        /// </summary>
        public const int elementId_actionTopRow2 = 8;
        
        /// <summary>
        /// Element identifier id for "Action Top Row 2".
        /// This is an alias for <see cref="elementId_actionTopRow2"/>.
        /// </summary>
        public const int elementId_y = 8;
        
        /// <summary>
        /// Element identifier id for "Action Top Row 3".
        /// </summary>
        public const int elementId_actionTopRow3 = 9;
        
        /// <summary>
        /// Element identifier id for "Action Top Row 3".
        /// This is an alias for <see cref="elementId_actionTopRow3"/>.
        /// </summary>
        public const int elementId_z = 9;
        
        /// <summary>
        /// Element identifier id for "Left Shoulder 1".
        /// </summary>
        public const int elementId_leftShoulder1 = 10;
        
        /// <summary>
        /// Element identifier id for "Left Shoulder 1".
        /// This is an alias for <see cref="elementId_leftShoulder1"/>.
        /// </summary>
        public const int elementId_leftBumper = 10;
        
        /// <summary>
        /// Element identifier id for "Left Shoulder 2".
        /// </summary>
        public const int elementId_leftShoulder2 = 11;
        
        /// <summary>
        /// Element identifier id for "Left Shoulder 2".
        /// This is an alias for <see cref="elementId_leftShoulder2"/>.
        /// </summary>
        public const int elementId_leftTrigger = 11;
        
        /// <summary>
        /// Element identifier id for "Right Shoulder 1".
        /// </summary>
        public const int elementId_rightShoulder1 = 12;
        
        /// <summary>
        /// Element identifier id for "Right Shoulder 1".
        /// This is an alias for <see cref="elementId_rightShoulder1"/>.
        /// </summary>
        public const int elementId_rightBumper = 12;
        
        /// <summary>
        /// Element identifier id for "Right Shoulder 2".
        /// </summary>
        public const int elementId_rightShoulder2 = 13;
        
        /// <summary>
        /// Element identifier id for "Right Shoulder 2".
        /// This is an alias for <see cref="elementId_rightShoulder2"/>.
        /// </summary>
        public const int elementId_rightTrigger = 13;
        
        /// <summary>
        /// Element identifier id for "Center 1".
        /// </summary>
        public const int elementId_center1 = 14;
        
        /// <summary>
        /// Element identifier id for "Center 1".
        /// This is an alias for <see cref="elementId_center1"/>.
        /// </summary>
        public const int elementId_back = 14;
        
        /// <summary>
        /// Element identifier id for "Center 2".
        /// </summary>
        public const int elementId_center2 = 15;
        
        /// <summary>
        /// Element identifier id for "Center 2".
        /// This is an alias for <see cref="elementId_center2"/>.
        /// </summary>
        public const int elementId_start = 15;
        
        /// <summary>
        /// Element identifier id for "Center 3".
        /// </summary>
        public const int elementId_center3 = 16;
        
        /// <summary>
        /// Element identifier id for "Center 3".
        /// This is an alias for <see cref="elementId_center3"/>.
        /// </summary>
        public const int elementId_guide = 16;
        
        /// <summary>
        /// Element identifier id for "Left Stick Button".
        /// </summary>
        public const int elementId_leftStickButton = 17;
        
        /// <summary>
        /// Element identifier id for "Right Stick Button".
        /// </summary>
        public const int elementId_rightStickButton = 18;
        
        /// <summary>
        /// Element identifier id for "D-Pad Up".
        /// </summary>
        public const int elementId_dPadUp = 19;
        
        /// <summary>
        /// Element identifier id for "D-Pad Right".
        /// </summary>
        public const int elementId_dPadRight = 20;
        
        /// <summary>
        /// Element identifier id for "D-Pad Down".
        /// </summary>
        public const int elementId_dPadDown = 21;
        
        /// <summary>
        /// Element identifier id for "D-Pad Left".
        /// </summary>
        public const int elementId_dPadLeft = 22;
        
        /// <summary>
        /// Element identifier id for "Left Stick".
        /// </summary>
        public const int elementId_leftStick = 23;
        
        /// <summary>
        /// Element identifier id for "Right Stick".
        /// </summary>
        public const int elementId_rightStick = 24;
        
        /// <summary>
        /// Element identifier id for "D-Pad".
        /// </summary>
        public const int elementId_dPad = 25;
        
        #endregion
        
        #region IGamepadTemplate implementation
        
        /// <summary>
        /// The "Action Bottom Row 1" element.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.actionBottomRow1 { get { return GetElement<IControllerTemplateButton>(elementId_actionBottomRow1); } }
        
        /// <summary>
        /// The "Action Bottom Row 1" element.
        /// This is an alias for <see cref="elementId_actionBottomRow1"/>.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.a { get { return GetElement<IControllerTemplateButton>(elementId_a); } }
        
        /// <summary>
        /// The "Action Bottom Row 2" element.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 2" element.</returns>
        IControllerTemplateButton IGamepadTemplate.actionBottomRow2 { get { return GetElement<IControllerTemplateButton>(elementId_actionBottomRow2); } }
        
        /// <summary>
        /// The "Action Bottom Row 2" element.
        /// This is an alias for <see cref="elementId_actionBottomRow2"/>.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 2" element.</returns>
        IControllerTemplateButton IGamepadTemplate.b { get { return GetElement<IControllerTemplateButton>(elementId_b); } }
        
        /// <summary>
        /// The "Action Bottom Row 3" element.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 3" element.</returns>
        IControllerTemplateButton IGamepadTemplate.actionBottomRow3 { get { return GetElement<IControllerTemplateButton>(elementId_actionBottomRow3); } }
        
        /// <summary>
        /// The "Action Bottom Row 3" element.
        /// This is an alias for <see cref="elementId_actionBottomRow3"/>.
        /// </summary>
        /// <returns>Returns the "Action Bottom Row 3" element.</returns>
        IControllerTemplateButton IGamepadTemplate.c { get { return GetElement<IControllerTemplateButton>(elementId_c); } }
        
        /// <summary>
        /// The "Action Top Row 1" element.
        /// </summary>
        /// <returns>Returns the "Action Top Row 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.actionTopRow1 { get { return GetElement<IControllerTemplateButton>(elementId_actionTopRow1); } }
        
        /// <summary>
        /// The "Action Top Row 1" element.
        /// This is an alias for <see cref="elementId_actionTopRow1"/>.
        /// </summary>
        /// <returns>Returns the "Action Top Row 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.x { get { return GetElement<IControllerTemplateButton>(elementId_x); } }
        
        /// <summary>
        /// The "Action Top Row 2" element.
        /// </summary>
        /// <returns>Returns the "Action Top Row 2" element.</returns>
        IControllerTemplateButton IGamepadTemplate.actionTopRow2 { get { return GetElement<IControllerTemplateButton>(elementId_actionTopRow2); } }
        
        /// <summary>
        /// The "Action Top Row 2" element.
        /// This is an alias for <see cref="elementId_actionTopRow2"/>.
        /// </summary>
        /// <returns>Returns the "Action Top Row 2" element.</returns>
        IControllerTemplateButton IGamepadTemplate.y { get { return GetElement<IControllerTemplateButton>(elementId_y); } }
        
        /// <summary>
        /// The "Action Top Row 3" element.
        /// </summary>
        /// <returns>Returns the "Action Top Row 3" element.</returns>
        IControllerTemplateButton IGamepadTemplate.actionTopRow3 { get { return GetElement<IControllerTemplateButton>(elementId_actionTopRow3); } }
        
        /// <summary>
        /// The "Action Top Row 3" element.
        /// This is an alias for <see cref="elementId_actionTopRow3"/>.
        /// </summary>
        /// <returns>Returns the "Action Top Row 3" element.</returns>
        IControllerTemplateButton IGamepadTemplate.z { get { return GetElement<IControllerTemplateButton>(elementId_z); } }
        
        /// <summary>
        /// The "Left Shoulder 1" element.
        /// </summary>
        /// <returns>Returns the "Left Shoulder 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.leftShoulder1 { get { return GetElement<IControllerTemplateButton>(elementId_leftShoulder1); } }
        
        /// <summary>
        /// The "Left Shoulder 1" element.
        /// This is an alias for <see cref="elementId_leftShoulder1"/>.
        /// </summary>
        /// <returns>Returns the "Left Shoulder 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.leftBumper { get { return GetElement<IControllerTemplateButton>(elementId_leftBumper); } }
        
        /// <summary>
        /// The "Left Shoulder 2" element.
        /// </summary>
        /// <returns>Returns the "Left Shoulder 2" element.</returns>
        IControllerTemplateAxis IGamepadTemplate.leftShoulder2 { get { return GetElement<IControllerTemplateAxis>(elementId_leftShoulder2); } }
        
        /// <summary>
        /// The "Left Shoulder 2" element.
        /// This is an alias for <see cref="elementId_leftShoulder2"/>.
        /// </summary>
        /// <returns>Returns the "Left Shoulder 2" element.</returns>
        IControllerTemplateAxis IGamepadTemplate.leftTrigger { get { return GetElement<IControllerTemplateAxis>(elementId_leftTrigger); } }
        
        /// <summary>
        /// The "Right Shoulder 1" element.
        /// </summary>
        /// <returns>Returns the "Right Shoulder 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.rightShoulder1 { get { return GetElement<IControllerTemplateButton>(elementId_rightShoulder1); } }
        
        /// <summary>
        /// The "Right Shoulder 1" element.
        /// This is an alias for <see cref="elementId_rightShoulder1"/>.
        /// </summary>
        /// <returns>Returns the "Right Shoulder 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.rightBumper { get { return GetElement<IControllerTemplateButton>(elementId_rightBumper); } }
        
        /// <summary>
        /// The "Right Shoulder 2" element.
        /// </summary>
        /// <returns>Returns the "Right Shoulder 2" element.</returns>
        IControllerTemplateAxis IGamepadTemplate.rightShoulder2 { get { return GetElement<IControllerTemplateAxis>(elementId_rightShoulder2); } }
        
        /// <summary>
        /// The "Right Shoulder 2" element.
        /// This is an alias for <see cref="elementId_rightShoulder2"/>.
        /// </summary>
        /// <returns>Returns the "Right Shoulder 2" element.</returns>
        IControllerTemplateAxis IGamepadTemplate.rightTrigger { get { return GetElement<IControllerTemplateAxis>(elementId_rightTrigger); } }
        
        /// <summary>
        /// The "Center 1" element.
        /// </summary>
        /// <returns>Returns the "Center 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.center1 { get { return GetElement<IControllerTemplateButton>(elementId_center1); } }
        
        /// <summary>
        /// The "Center 1" element.
        /// This is an alias for <see cref="elementId_center1"/>.
        /// </summary>
        /// <returns>Returns the "Center 1" element.</returns>
        IControllerTemplateButton IGamepadTemplate.back { get { return GetElement<IControllerTemplateButton>(elementId_back); } }
        
        /// <summary>
        /// The "Center 2" element.
        /// </summary>
        /// <returns>Returns the "Center 2" element.</returns>
        IControllerTemplateButton IGamepadTemplate.center2 { get { return GetElement<IControllerTemplateButton>(elementId_center2); } }
        
        /// <summary>
        /// The "Center 2" element.
        /// This is an alias for <see cref="elementId_center2"/>.
        /// </summary>
        /// <returns>Returns the "Center 2" element.</returns>
        IControllerTemplateButton IGamepadTemplate.start { get { return GetElement<IControllerTemplateButton>(elementId_start); } }
        
        /// <summary>
        /// The "Center 3" element.
        /// </summary>
        /// <returns>Returns the "Center 3" element.</returns>
        IControllerTemplateButton IGamepadTemplate.center3 { get { return GetElement<IControllerTemplateButton>(elementId_center3); } }
        
        /// <summary>
        /// The "Center 3" element.
        /// This is an alias for <see cref="elementId_center3"/>.
        /// </summary>
        /// <returns>Returns the "Center 3" element.</returns>
        IControllerTemplateButton IGamepadTemplate.guide { get { return GetElement<IControllerTemplateButton>(elementId_guide); } }
        
        /// <summary>
        /// The "Left Stick" element.
        /// </summary>
        /// <returns>Returns the "Left Stick" element.</returns>
        IControllerTemplateThumbStick IGamepadTemplate.leftStick { get { return GetElement<IControllerTemplateThumbStick>(elementId_leftStick); } }
        
        /// <summary>
        /// The "Right Stick" element.
        /// </summary>
        /// <returns>Returns the "Right Stick" element.</returns>
        IControllerTemplateThumbStick IGamepadTemplate.rightStick { get { return GetElement<IControllerTemplateThumbStick>(elementId_rightStick); } }
        
        /// <summary>
        /// The "D-Pad" element.
        /// </summary>
        /// <returns>Returns the "D-Pad" element.</returns>
        IControllerTemplateDPad IGamepadTemplate.dPad { get { return GetElement<IControllerTemplateDPad>(elementId_dPad); } }
        
        #endregion
        
        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        public GamepadTemplate(object payload) : base(payload) { }
    }
    
    #endregion
}

#region Internal

namespace Rewired.Internal {
    using System;
    
    /// <summary>
    /// Factory class for creating Controller Templates.
    /// This is for internal use only.
    /// </summary>
    public static partial class ControllerTemplateFactory {
        
        private static readonly Type[] _userTemplateTypes = new Type[] {
            typeof(GamepadTemplate)
        };
        
        private static readonly Type[] _userTemplateInterfaceTypes = new Type[] {
            typeof(IGamepadTemplate)
        };
        
        private static IControllerTemplate CreateUser(Guid typeGuid, object payload) {
            if(typeGuid == GamepadTemplate.typeGuid) return new GamepadTemplate(payload);
            return null;
        }
    }
}

#endregion

#endif
