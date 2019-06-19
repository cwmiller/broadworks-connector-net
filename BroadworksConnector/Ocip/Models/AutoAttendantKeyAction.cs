using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The action of Auto Attendant key.
    /// The following data elements are only used in AS data mode and ignored in XS data mode:
    /// Transfer To Mailbox
    /// Play Announcement
    /// Transfer To Submenu
    /// Return to Previous Menu
    /// The following data elements are only valid for Standard Auto
    /// Attendants:
    /// Transfer To Submenu
    /// Return to Previous Menu
    /// The following data elements are only valid for submenus:
    /// Return to Previous Menu
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutoAttendantKeyAction
    {
        [XmlEnum(Name = "Transfer With Prompt")]
        TransferWithPrompt,
        [XmlEnum(Name = "Transfer Without Prompt")]
        TransferWithoutPrompt,
        [XmlEnum(Name = "Transfer To Operator")]
        TransferToOperator,
        [XmlEnum(Name = "Name Dialing")]
        NameDialing,
        [XmlEnum(Name = "Extension Dialing")]
        ExtensionDialing,
        [XmlEnum(Name = "Repeat Menu")]
        RepeatMenu,
        [XmlEnum(Name = "Exit")]
        Exit,
        [XmlEnum(Name = "Transfer To Mailbox")]
        TransferToMailbox,
        [XmlEnum(Name = "Transfer To Submenu")]
        TransferToSubmenu,
        [XmlEnum(Name = "Return to Previous Menu")]
        ReturntoPreviousMenu,
        [XmlEnum(Name = "Play Announcement")]
        PlayAnnouncement,
    }
}
